using Microsoft.AspNetCore.Mvc;

namespace ThriveHavenMovies.Controllers
{
    public class Business : Controller
    {
        public IActionResult BusinessPage()
        {
            return View();
        }
    }
}