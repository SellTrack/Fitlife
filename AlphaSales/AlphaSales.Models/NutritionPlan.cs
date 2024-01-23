using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AlphaSales.Models
{
    public class NutritionPlan
    {
        [Key]
        public int ExercisePlan_id { get; set; }
        public string Exercise_Name { get; set; }
        public int Set_count { get; set; }
        public int Repeat_Count { get; set; }
        public string VideoLinkUrl { get; set; }
        public DateTime StartDate { get; set; }
        public int ExerciseDuration { get; set; }
        public int status { get; set; }
        public string Client_id { get; set; }
        public string Coach_id { get; set; }
        [ValidateNever]
        [ForeignKey("Coach_id")]
        public ApplicationUser ApplicationUser { get; set; }
        [ValidateNever]
        [ForeignKey("Client_id")]
        public ApplicationUser ApplicationUser2 { get; set; }

    }
}
