﻿using RegistrationForm.Models;
using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.InputModels
{
    public class RegisterIM
    {
        [Display(Name = "Jméno")]
        [Required(ErrorMessage = "Jméno musí být zadáno.")]
        public string FirstName {  get; set; }
        [Display(Name = "Příjmení")]
        [Required(ErrorMessage = "Příjmení musí být zadáno.")]
        public string LastName { get; set; }
        [Display(Name = "Datum narození")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Název školy")]
        public string SchoolName { get; set; }
        [Display(Name = "Ročník")]
        [Required(ErrorMessage = "Ročník musí být zadán.")]
        public SchoolGrade Grade { get; set; }
        [Display(Name = "Zájemce o studium")]
        public bool Aspirant { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email musí být zadán.")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Heslo")]
        [Required(ErrorMessage = "Heslo musí být zadáno.")]
        public string Password { get; set; }
    }
}
