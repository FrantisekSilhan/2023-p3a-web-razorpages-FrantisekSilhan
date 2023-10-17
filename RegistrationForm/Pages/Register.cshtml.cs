using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RegistrationForm.InputModels;

namespace RegistrationForm.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public RegisterIM RegisterIM { get; set; } = new RegisterIM();
        public List<SelectListItem> SelectDays { get; set; } = new List<SelectListItem>();
        public void OnGet(string email)
        {
            RegisterIM.Email = email;

            int i = 1;
            foreach (var item in new[] { "Pondělí", "Úterý", "Středa", "Čtvrtek", "Pátek" })
            {
                SelectDays.Add(new SelectListItem(item, i.ToString(), i++ == 2));
            }
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
