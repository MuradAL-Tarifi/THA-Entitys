using System;
using System.Collections.Generic;

namespace THA_Entitys.Models
{
    public class Address : BaseDataModel
    {
        public string AddressDetails { get; set; } = null!;
        public string? ApplicationUserId { get; set; }

        public virtual ApplicationUser? ApplicationUser{ get; set; }
    }
}
