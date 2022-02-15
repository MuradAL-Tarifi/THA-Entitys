using System;
using System.Collections.Generic;

namespace THA_Entitys.Models
{
    public class TypeOfTraining : BaseDataModel
    {
        public TypeOfTraining()
        {
            Trainees = new HashSet<Trainee>();
        }

        public string Type { get; set; } = null!;

        public virtual ICollection<Trainee> Trainees { get; set; }
    }
}
