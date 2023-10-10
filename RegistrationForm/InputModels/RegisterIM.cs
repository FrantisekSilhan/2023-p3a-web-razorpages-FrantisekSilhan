using RegistrationForm.Models;
using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.InputModels
{
    public class RegisterIM
    {
        [Required]
        public string FirstName {  get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string SchoolName { get; set; }
        [Required]
        public SchoolGrade Grade { get; set; }
        public bool Aspirant { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
