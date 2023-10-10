using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RegistrationForm.InputModels;

namespace RegistrationForm.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public RegisterIM RegisterIM { get; set; } = new RegisterIM();
        public void OnGet(string email)
        {
            RegisterIM.Email = email;
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return RedirectToPage("/RegistrationResult", new
                {
                    firstName = RegisterIM.FirstName,
                    email = RegisterIM.Email
                });
            }

            return Page();
        }
    }
}
