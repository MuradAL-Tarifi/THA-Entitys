using System;
using System.Collections.Generic;

namespace THA_Entitys.Models
{
    public class CompaniesRequestForTraining: BaseDataModel
    {
        public string TrainingPathName { get; set; } = null!;
        public int Capacity { get; set; }
        public DateTime TrainingPeriodFrom { get; set; }
        public DateTime TrainingPeriodTo { get; set; }
        public string Note { get; set; } = null!;
        public string Status { get; set; } = null!;
        public int? CreatedByUserId { get; set; }
        public int? CompanyId { get; set; }

        public virtual Company? Company { get; set; }
    }
}
