using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace THA_Entitys.Models
{
    public class TypeOfTraining : BaseDataModel
    {
        public TypeOfTraining()
        {
            Trainees = new HashSet<Trainee>();
        }
        [MaxLength(256)]
        public string Type { get; set; } 

        public virtual ICollection<Trainee> Trainees { get; set; }
    }
}
