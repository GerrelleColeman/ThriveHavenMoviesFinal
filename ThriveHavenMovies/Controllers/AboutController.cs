using Microsoft.AspNetCore.Mvc;

namespace ThriveHavenMovies.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
