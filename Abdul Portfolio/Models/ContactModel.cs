using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abdul_Portfolio.Models
{
    public class ContactModel 
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Subject { get; set; }
        [BindProperty]
        public string Message { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            // TODO: handle form submission (e.g., send email, save to DB)
        }
    }
}
