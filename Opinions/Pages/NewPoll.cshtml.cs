using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Opinions.Pages
{
    public class NewPollModel : PageModel
    {
        private readonly ILogger<NewPollModel> _logger;

        public NewPollModel(ILogger<NewPollModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Timestamp"] = DateTime.Now.ToString("dd.MM.yy hh:mm");
        }
    }
}