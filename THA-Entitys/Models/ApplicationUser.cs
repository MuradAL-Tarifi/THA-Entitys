using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace THA_Entitys.Models
{
    public class ApplicationUser: BaseDataModel
    {
        public ApplicationUser()
        {
            Notifications = new HashSet<Notification>();
            Roles = new HashSet<Role>();
        }

        public int? CreatedByUserId { get; set; }
        [MaxLength(256)]
        public string UserName { get; set; }
        [MaxLength(256)]
        public string Email { get; set; }
        [MaxLength(256)]
        public string PasswordHash { get; set; } 
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool? LockoutEnabled { get; set; }
        public Status state { get; set; }
        public enum Status { InProgress, Accepted, Rejected };
        public int AddressId { get; set; }
        public int CompanyId { get; set; }
        public int TraineesId { get; set; }

        public virtual Address address { get; set; }
        public virtual Company company { get; set; }
        public virtual Trainee Trainees { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
