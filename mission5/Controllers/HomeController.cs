using Microsoft.AspNetCore.Mvc;

namespace mission5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("price");
        }

        public IActionResult price()
        {
            return View();
        }
    }
}
