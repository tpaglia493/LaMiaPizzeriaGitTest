using Microsoft.AspNetCore.Mvc;

namespace LaMiaPizzeria.Controllers
{
    public class DrinkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
