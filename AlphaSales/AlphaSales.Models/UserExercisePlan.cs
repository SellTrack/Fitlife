using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AlphaSales.Models
{
    public class UserExercisePlan
    {
        [Key]
        public int UserExercisePlan_id { get; set; }
        public int Exercise_id { get; set; }
        public string Client_id { get; set; }
        [ValidateNever]
        [ForeignKey("Exercise_id")]
        public ExercisePlan ExercisePlan { get; set; }
        [ValidateNever]
        [ForeignKey("Client_id")]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
