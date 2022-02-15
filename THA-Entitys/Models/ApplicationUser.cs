using System;
using System.Collections.Generic;

namespace THA_Entitys.Models
{
    public partial class ApplicationUser: BaseDataModel
    {
        public ApplicationUser()
        {
            Addresses = new HashSet<Address>();
            Companies = new HashSet<Company>();
            Notifications = new HashSet<Notification>();
            Trainees = new HashSet<Trainee>();
            Roles = new HashSet<Role>();
        }

        public string Status { get; set; } = null!;
        public int? CreatedByUserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool? LockoutEnabled { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
