using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace THA_Entitys.Models
{
    public class Company: BaseDataModel
    {
        public Company()
        {
            CompanyRequests = new HashSet<CompanyRequest>();
        }
        [MaxLength(256)]
        public string CompanyName { get; set; }
        [MaxLength(256)]
        public string CompanyEmail { get; set; }
        [MaxLength(256)]
        public string CompanyWebsite { get; set; }
        [MaxLength(256)]
        public string CompanyLicense { get; set; }
        [MaxLength(256)]
        public string Role { get; set; }
        [MaxLength(256)]
        public string Payment { get; set; } 
        public int? UserId { get; set; }

        public virtual ApplicationUser? User { get; set; }
        public virtual ICollection<CompanyRequest> CompanyRequests { get; set; }
    }
}
