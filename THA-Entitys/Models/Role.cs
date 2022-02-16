using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace THA_Entitys.Models
{
    public class Role : BaseDataModel
    {
        public Role()
        {
            Users = new HashSet<ApplicationUser>();
        }
        [MaxLength(256)]
        public string RoleName { get; set; } 

        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}
