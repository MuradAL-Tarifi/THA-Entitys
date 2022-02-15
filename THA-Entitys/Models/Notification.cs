using System;
using System.Collections.Generic;

namespace THA_Entitys.Models
{
    public partial class Notification : BaseDataModel
    {
        public string Subject { get; set; } = null!;
        public bool IsRead { get; set; }
        public int? UserId { get; set; }

        public virtual ApplicationUser? User { get; set; }
    }
}
