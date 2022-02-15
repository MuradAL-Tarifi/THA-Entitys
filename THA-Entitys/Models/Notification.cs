using System;
using System.Collections.Generic;

namespace THA_Entitys.Models
{
    public class Notification : BaseDataModel
    {
        public string Subject { get; set; } = null!;
        public bool IsRead { get; set; }
        public string? ApplicationUserId { get; set; }

        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
