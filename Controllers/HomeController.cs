using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management_System.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();   // Loads Views/Home/Index.cshtml
        }

        public IActionResult Privacy()
        {
            return View();   // Loads Views/Home/Privacy.cshtml
        }
    }
}
