using IMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IMS.Domain.Models
{
    public class Profile
    {
        [Key] public Guid Id { get; set; }
        [Required] public String FullName { get; set; }
        public int age { get; set; }
        public DateTime birthday {get;set;}
        public Gender gender { get; set; }



    }
}
