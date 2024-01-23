using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AlphaSales.Models
{
    public class UserSpeciality
    {
        [Key]
        public int UserSpeciality_id { get; set; }
        public string User_id { get; set; }
        public int Speciality_id { get; set; }
        [ValidateNever]
        [ForeignKey("User_id")]
        public ApplicationUser ApplicationUser { get; set; }
        [ValidateNever]
        [ForeignKey("Speciality_id")]
        public Speciality Speciality { get; set; }
    }
}
