using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace THA_Entitys.Models
{
    public class Project : BaseDataModel
    {
        [MaxLength(256)]
        public string ProjectName { get; set; } 
        public int? TraineeId { get; set; }

        public virtual Trainee? Trainee { get; set; }
    }
}
