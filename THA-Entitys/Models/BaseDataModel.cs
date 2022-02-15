using System;
using System.ComponentModel.DataAnnotations;

namespace THA_Entitys.Models
{
    public class BaseDataModel
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}