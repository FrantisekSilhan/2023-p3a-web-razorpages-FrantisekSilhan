using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RegistrationForm.InputModels;

namespace RegistrationForm.Pages
{
    public class RegistrationResultModel : PageModel
    {
        public string Firstname { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public bool Success { get; set; }
        public void OnGet(string firstname, string email)
        {
            Firstname = firstname;
            Email = email;
            Success = ModelState.IsValid;
        }
    }
}
