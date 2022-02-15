using System;
using System.Collections.Generic;

namespace THA_Entitys.Models
{
    public partial class Role : BaseDataModel
    {
        public Role()
        {
            Users = new HashSet<ApplicationUser>();
        }

        public string RoleName { get; set; } = null!;

        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}
