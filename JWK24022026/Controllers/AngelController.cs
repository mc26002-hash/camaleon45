using Microsoft.AspNetCore.Mvc;

namespace JWK24022026.AppMVC.Controllers
{
    public class AngelController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double numero1, double numero2, string operacion)
        {
            double resultado = 0;

            if (operacion == "Sumar")
            {
                resultado = numero1 + numero2;
            }
            else if (operacion == "Restar")
            {
                resultado = numero1 - numero2;
            }

            ViewBag.Numero1 = numero1;
            ViewBag.Numero2 = numero2;
            ViewBag.Resultado = resultado;

            return View();
        }
    }
}