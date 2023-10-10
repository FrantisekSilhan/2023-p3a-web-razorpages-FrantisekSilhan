﻿using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
    public enum SchoolGrade
    {
        [Display(Name = "Žádný")]
        None = 0,
        [Display(Name = "Základní škola 1-7")]
        Lesser = 7,
        [Display(Name = "Osmák")]
        Eight = 8,
        [Display(Name = "Deváťák")]
        Ninth = 9,
        [Display(Name = "Středoškolák")]
        Higher = 10
    }
}
