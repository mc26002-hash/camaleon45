using Microsoft.AspNetCore.Mvc;

namespace JWK24022026.Controllers
{
    public class WilliamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
         
        public IActionResult Multiplicar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Multiplicar(double num1, double num2)
        {
            ViewBag.Resultado = num1 * num2;
            return View();
        }
        public IActionResult Dividir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Dividir(double num1, double num2)
        {
            if (num2 == 0)
            {
                ViewBag.Resultado = "No se puede dividir entre 0";
            }
            else
            {
                ViewBag.Resultado = num1 / num2;
            }

            return View();
        }
    }
}
