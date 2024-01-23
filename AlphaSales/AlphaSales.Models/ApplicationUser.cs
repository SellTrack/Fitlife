using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AlphaSales.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Adress { get; set; }
        public DateTime Birtdate { get; set; }
        public string gender { get; set; }
        public string Role { get; set; }
        public string profilephotopath { get; set; }
    }
}
