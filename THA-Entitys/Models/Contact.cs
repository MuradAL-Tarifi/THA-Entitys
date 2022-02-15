using System;
using System.Collections.Generic;

namespace THA_Entitys.Models
{
    public class Contact: BaseDataModel
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Message { get; set; } = null!;
    }
}
