using Aula30082022.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Aula30082022.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Resultado = 0;
            return View(new ValoresCalculadora());
        }

        [HttpPost]
        public IActionResult IndexSoma(ValoresCalculadora form)
        {

            if (form.Operacao == Operacoes.Soma)
                form.resultado = form.Valor2 + form.Valor2;

            ViewBag.Resultado = form.resultado;
            return View(form);
        }

    }
}
