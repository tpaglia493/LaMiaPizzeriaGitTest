using LaMiaPizzeria.DataBase;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Drink newDrink)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", newDrink);
            }

            using (PizzaContext db = new PizzaContext())
            {
                db.Drinks.Add(newDrink);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}
