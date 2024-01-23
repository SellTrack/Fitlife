using System;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace AlphaSales.Models.ViewModels
{
	
        public class UserProfileViewModel
        {
        [ValidateNever]
        public string? UserName { get; set; }
        [ValidateNever]
        public string? Email { get; set; }

    }
    
}

