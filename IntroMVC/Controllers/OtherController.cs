using Microsoft.AspNetCore.Mvc;

namespace IntroMVC.Controllers
{
    public class OtherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("/stuff/{year:min(2020)}/{month:range(1,12)}/{key}")]
        public IActionResult Details(int year, int month, string key)
        {
            ViewBag.year = year;
            ViewBag.month = month;
            ViewBag.key = key;
            return View();
        }
        public IActionResult PageOne()
        {
            return View();
        }
    }
}
