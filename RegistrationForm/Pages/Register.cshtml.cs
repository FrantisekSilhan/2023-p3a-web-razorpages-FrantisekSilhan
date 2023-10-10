using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RegistrationForm.InputModels;

namespace RegistrationForm.Pages
{
    public class RegisterModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
