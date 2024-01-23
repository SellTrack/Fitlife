using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AlphaSales.Models
{
    public class Matchmaking
    {
        [Key]
        public int Matchmaking_id { get; set; }
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
