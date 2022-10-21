using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography;

namespace TrainWebApp.Pages
{
    public class ContactModel : PageModel
    {
        [TempData]
        public string FeedbackMessage { get; set; }
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public string Subject { get; set; }
        [BindProperty]
        public string Message { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            FeedbackMessage = $"<h2>{Username}, {Subject}, {Title}</h2>";
        }
    }
}
