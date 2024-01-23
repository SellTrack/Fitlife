using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace AlphaSales.Models.ViewModels
{
    public class UserSpecialityViewModel
    {
        [ValidateNever]
        public string? UserName { get; set; }

        [ValidateNever]
        public string? Email { get; set; }

        [ValidateNever]
        public UserSpeciality UserSpeciality { get; set; }

        [ValidateNever]
        public List<ApplicationUser> Users { get; set; } // Kullanıcıları içeren liste

        [ValidateNever]
        public List<Speciality> Specialities { get; set; } // Uzmanlık alanlarını içeren liste
    }
}
