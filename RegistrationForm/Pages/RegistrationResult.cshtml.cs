using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RegistrationForm.Pages
{
    public class RegistrationResultModel : PageModel
    {
        public string Firstname { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public bool Success { get; set; }
        public void OnGet()
        {

        }
    }
}
