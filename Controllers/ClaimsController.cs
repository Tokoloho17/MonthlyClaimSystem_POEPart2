using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MonthlyClaimSystem_POEPart2.Models;
using System.IO;
using System.Threading.Tasks;

namespace MonthlyClaimSystem_POEPart2.Controllers
{
    public class ClaimsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClaimsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult SubmitClaim()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SubmitClaim(Claim claim)
        {
            if (ModelState.IsValid)
            {
                // Handle file upload
                var file = Request.Form.Files["Document"];
                if (file != null && file.Length > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    claim.DocumentPath = fileName;
                }

                await _context.Claims.AddAsync(claim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ManageClaims)); // Redirect to ManageClaims
            }
            return View(claim);
        }

        public async Task<IActionResult> ManageClaims()
        {
            var claims = await _context.Claims.ToListAsync();
            return View(claims); // Return the list of claims
        }

        public async Task<IActionResult> TrackStatus()
        {
            var claims = await _context.Claims.ToListAsync();
            return View(claims); // Return the list of claims
        }
    }
}
