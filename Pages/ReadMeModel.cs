using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MarsRover.Pages
{
    public class ReadMeModel : PageModel
    {
        private readonly ILogger<ReadMeModel> _logger;

        public ReadMeModel(ILogger<ReadMeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}