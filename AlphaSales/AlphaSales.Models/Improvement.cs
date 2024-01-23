using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AlphaSales.Models
{
    public class Improvement
    {
        [Key]
        public int Improvement_id { get; set; }
        public string User_id { get; set; }
        public DateTime RegisterDate { get; set; }
        public int BMIChange { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        [ValidateNever]
        [ForeignKey("User_id")]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
