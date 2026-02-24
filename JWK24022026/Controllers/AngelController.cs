using Microsoft.AspNetCore.Mvc;

namespace JWK24022026.AppMVC.Controllers
{
    public class AngelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Suma()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Suma(double num1, double num2)
        {
            ViewBag.Resultado = num1 + num2;
            return View();
        }

        public IActionResult Restar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Restar(double num1, double num2)
        {
            ViewBag.Resultado = num1 - num2;
            return View();
        }
    }
}
