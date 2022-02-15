using System;
using System.Collections.Generic;

namespace THA_Entitys.Models
{
    public class Trainee : BaseDataModel
    {
        public Trainee()
        {
            Projects = new HashSet<Project>();
        }

        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string University { get; set; } = null!;
        public DateTime? BirthDate { get; set; }
        public bool GenderIsMale { get; set; }
        public decimal? Gpa { get; set; }
        public string Nationality { get; set; } = null!;
        public string? Major { get; set; }
        public DateTime? DateOfGraduation { get; set; }
        public string LinkedinUrl { get; set; } = null!;
        public string JobTitle { get; set; } = null!;
        public string CvUrl { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public int? TypeOfTrainingId { get; set; }
        public string? ApplicationUserId { get; set; }

        public virtual ApplicationUser? ApplicationUser { get; set; }

        public virtual TypeOfTraining? TypeOfTraining { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
