using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AlphaSales.Models
{
    public class Speciality
    {
        [Key]
        public int Speciality_id { get; set; }
        public string SpecialityName { get; set; }
    }
}
