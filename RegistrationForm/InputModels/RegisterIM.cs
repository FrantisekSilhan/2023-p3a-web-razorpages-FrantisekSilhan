using RegistrationForm.Models;
using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.InputModels
{
    public class RegisterIM
    {
        [Display(Name = "Jméno")]
        [Required]
        public string FirstName {  get; set; }
        [Display(Name = "Příjmení")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Datum narození")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Název školy")]
        public string SchoolName { get; set; }
        [Required]
        [Display(Name = "Ročník")]
        public SchoolGrade Grade { get; set; }
        [Display(Name = "Zájemce o studium")]
        public bool Aspirant { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Heslo")]
        public string Password { get; set; }
    }
}
