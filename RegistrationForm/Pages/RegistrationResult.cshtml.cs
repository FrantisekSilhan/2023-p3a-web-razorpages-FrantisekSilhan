using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Pages
{
    public class RegistrationResultModel : PageModel
    {
        public string Firstname { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public bool Success { get; set; }
        public void OnGet(string firstname, [EmailAddress] string email)
        {
            Firstname = firstname;
            Email = email;
            Success = ModelState.IsValid;
        }
    }
}
