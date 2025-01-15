using Microsoft.AspNetCore.Mvc;

namespace IntroMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
