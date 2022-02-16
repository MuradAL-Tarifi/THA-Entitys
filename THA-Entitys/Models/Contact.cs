using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace THA_Entitys.Models
{
    public class Contact: BaseDataModel
    {
        [MaxLength(256)]
        public string Name { get; set; } 
        [MaxLength(256)]
        public string Email { get; set; } 
        [MaxLength(256)]
        public string Message { get; set; } 
    }
}
