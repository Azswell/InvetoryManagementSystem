using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IMS.Domain.Models
{
    public class Programs
    {
        
        [Key] public int Id { get; set; }
        [Required] public string? Name { get; set; }
        public String? Description { get; set; }
    }
}
