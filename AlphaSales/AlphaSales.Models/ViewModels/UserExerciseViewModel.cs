using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace AlphaSales.Models.ViewModels
{
    public class UserExerciseViewModel
    {
        [ValidateNever]
        public string? UserName { get; set; }

        [ValidateNever]
        public string? Email { get; set; }

        [ValidateNever]
        public UserExercisePlan UserExercisePlan { get; set; }

        [ValidateNever]
        public List<ApplicationUser> Users { get; set; } // Kullanıcıları içeren liste

        [ValidateNever]
        public List<ExercisePlan> ExercisePlans { get; set; } // Uzmanlık alanlarını içeren liste
    }
}
