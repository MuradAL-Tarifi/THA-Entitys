using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace THA_Entitys.Models
{
    public class CompanyRequest: BaseDataModel
    {
        [MaxLength(256)]
        public string TrainingPathName { get; set; }
        public int Capacity { get; set; }
        public DateTime TrainingPeriodFrom { get; set; }
        public DateTime TrainingPeriodTo { get; set; }
        [Required]
        [MaxLength(256)]
        public string Note { get; set; }

        public Status state { get; set; }
        public enum Status { InProgress, Accepted, Rejected }
        public int CreatedByUserId { get; set; }
        [Required]
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; } = null!;
    }
}
