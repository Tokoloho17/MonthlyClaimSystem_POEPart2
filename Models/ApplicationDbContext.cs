using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MonthlyClaimSystem_POEPart2.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Claim> Claims { get; set; }
    }
}
