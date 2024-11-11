using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace BasicRazorApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string Env { get; set; }

        public IndexModel(ILogger<IndexModel> logger,IConfiguration config)
        {
            _logger = logger;
            Env = config.GetSection("Environment").Value;
        }

        public void OnGet()
        {

        }
    }
}
