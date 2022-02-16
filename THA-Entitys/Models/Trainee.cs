using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace THA_Entitys.Models
{
    public class Trainee : BaseDataModel
    {
        public Trainee()
        {
            Projects = new HashSet<Project>();
        }
        [MaxLength(256)]
        public string FullName { get; set; }
        [MaxLength(256)]
        public string Email { get; set; }
        [MaxLength(256)]
        public string University { get; set; } 
        public DateTime? BirthDate { get; set; }
        public bool GenderIsMale { get; set; }
        public decimal? Gpa { get; set; }
        [MaxLength(256)]
        public string Nationality { get; set; } 
        public string? Major { get; set; }
        public DateTime? DateOfGraduation { get; set; }
        [MaxLength(256)]
        public string LinkedinUrl { get; set; }
        [MaxLength(256)]
        public string JobTitle { get; set; }
        [MaxLength(256)]
        public string CvUrl { get; set; }
        [MaxLength(256)]
        public string ImageUrl { get; set; }
        [MaxLength(256)]
        public string PhoneNumber { get; set; }
        public int? TypeOfTrainingId { get; set; }
        public int? UserId { get; set; }

        public virtual TypeOfTraining? TypeOfTraining { get; set; }
        public virtual ApplicationUser? User { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
