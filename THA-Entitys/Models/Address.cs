using System;
using System.Collections.Generic;

namespace THA_Entitys.Models
{
    public partial class Address : BaseDataModel
    {
        public string AddressDetails { get; set; } = null!;
        public int? UserId { get; set; }

        public virtual ApplicationUser? User { get; set; }
    }
}
