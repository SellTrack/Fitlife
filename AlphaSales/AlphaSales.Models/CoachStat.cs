using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AlphaSales.Models
{
    public class CoachStat
    {
        [Key]
        public int CoachStat_id { get; set; }
        public string User_id { get; set; }
        public string Experience { get; set; }
        [ValidateNever]
        [ForeignKey("User_id")]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
