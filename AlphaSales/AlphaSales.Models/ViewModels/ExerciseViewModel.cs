using System;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace AlphaSales.Models.ViewModels
{
	
        public class ExerciseViewModel
        {
        [ValidateNever]
        public string? UserName { get; set; }
        [ValidateNever]
        public string? Email { get; set; }
        [ValidateNever]
        public ExercisePlan ExercisePlan { get; set; }
        [ValidateNever]
        public UserExercisePlan UserExercisePlan { get; set; }
        [ValidateNever]
        public List<ApplicationUser> Users { get; set; } // Kullanıcıları içeren liste

    }

}