using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Opinions.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Timestamp"] = DateTime.Now.ToString("dd.MM.yy hh:mm");
        }
    }
}