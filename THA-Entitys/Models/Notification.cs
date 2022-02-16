using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace THA_Entitys.Models
{
    public class Notification : BaseDataModel
    {
        [MaxLength(256)]
        public string Subject { get; set; }
        public bool IsRead { get; set; }
        public int? UserId { get; set; }

        public virtual ApplicationUser? User { get; set; }
    }
}
