using System;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AlphaSales.Models.ViewModels
{
	public class RoleManagementVM
	{
		public ApplicationUser ApplicationUser { get; set; }
        public IEnumerable<SelectListItem> RoleList { get; set; }
        [ValidateNever]
        public string UserName { get; set; }
        [ValidateNever]
        public string Email { get; set; }

    }
}

