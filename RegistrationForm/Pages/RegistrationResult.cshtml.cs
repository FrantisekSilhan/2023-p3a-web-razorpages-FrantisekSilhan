using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Pages
{
    public class RegistrationResultModel : PageModel
    {
        public string Firstname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool Success { get; set; }
        [TempData]
        public string RegisterResult { get; set; } = string.Empty;
        public void OnGet(string firstname, [EmailAddress] string email)
        {
            Firstname = firstname;
            Email = email;
            Success = ModelState.IsValid;
        }
    }
}
