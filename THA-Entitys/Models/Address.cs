using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace THA_Entitys.Models
{
    public class Address : BaseDataModel
    {
        [MaxLength(256)]
        public string AddressDetails { get; set; }
        public int? UserId { get; set; }

        public virtual ApplicationUser? User { get; set; }
    }
}
