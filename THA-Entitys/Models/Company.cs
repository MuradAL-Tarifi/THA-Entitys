using System;
using System.Collections.Generic;

namespace THA_Entitys.Models
{
    public class Company: BaseDataModel
    {
        public Company()
        {
            CompanyRequests = new HashSet<CompanyRequest>();
        }

        public string CompanyName { get; set; } = null!;
        public string CompanyEmail { get; set; } = null!;
        public string CompanyWebsite { get; set; } = null!;
        public string CompanyLicense { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string Payment { get; set; } = null!;
        public int? UserId { get; set; }

        public virtual ApplicationUser? User { get; set; }
        public virtual ICollection<CompanyRequest> CompanyRequests { get; set; }
    }
}
