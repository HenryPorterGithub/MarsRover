using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MarsRover.Pages
{
    public class IndexModel : PageModel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Direction { get; set; }
        public string Movements { get; set; }
    }
}