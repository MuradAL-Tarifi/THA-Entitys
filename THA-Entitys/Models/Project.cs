using System;
using System.Collections.Generic;

namespace THA_Entitys.Models
{
    public partial class Project : BaseDataModel
    {
        public string ProjectName { get; set; } = null!;
        public int? TraineeId { get; set; }

        public virtual Trainee? Trainee { get; set; }
    }
}
