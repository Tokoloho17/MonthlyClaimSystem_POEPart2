using System;
using System.ComponentModel.DataAnnotations;

namespace MonthlyClaimSystem_POEPart2.Models
{
    public class Claim
    {
        public int Id { get; set; }

        [Required]
        public string LecturerName { get; set; }

        [Required]
        public decimal HourlyRate { get; set; }

        [Required]
        public int HoursWorked { get; set; }

        public string AdditionalNotes { get; set; }

        public string DocumentPath { get; set; }

        public string Status { get; set; } = "Pending";

        public DateTime SubmittedAt { get; set; } = DateTime.Now;
    }
}
