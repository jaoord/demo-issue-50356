using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty(SupportsGet = true)]
        public string From { get; set; }
        [BindProperty(SupportsGet = true)]
        public string To { get; set; }
        [BindProperty(SupportsGet = true)]
        public int? MinFlightTime { get; set; }
        [BindProperty(SupportsGet = true)]
        public int? MaxFlightTime { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}