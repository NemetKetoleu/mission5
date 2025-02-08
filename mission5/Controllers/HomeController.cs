using Microsoft.AspNetCore.Mvc;

namespace mission5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult price()
        {
            return View();
        }
    }
}
