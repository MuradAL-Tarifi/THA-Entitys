using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace THA_Entitys.Models
{
    public class ApplicationUser: IdentityUser
    {
        public ApplicationUser()
        {
            Addresses = new HashSet<Address>();
            Companies = new HashSet<Company>();
            Notifications = new HashSet<Notification>();
            Trainees = new HashSet<Trainee>();
        }

        public string Status { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public int? CreatedByUserId { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; }

    }
}
