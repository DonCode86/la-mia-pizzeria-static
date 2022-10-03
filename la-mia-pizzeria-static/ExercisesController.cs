using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static
{
    public class ExercisesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
