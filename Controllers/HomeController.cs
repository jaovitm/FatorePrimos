using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using FatoresPrimos.Services;


namespace FatoresPrimos.Controllers
{
    public class HomeController : Controller
    {
        private MathService _mathServices;

        public HomeController()
        {
            _mathServices = new MathService();
        }

        public ActionResult Index(int numero)
        {

            if(numero == 0)
                return Json(new { numero = numero, mensagem = "Desculpe, zero não tem nenhum divisor!" }, JsonRequestBehavior.AllowGet);

            var divisores = _mathServices.Decompor(numero);
            var divisoresPrimos = _mathServices.Primos(divisores);

            return Json(new { numero, divisores, divisoresPrimos }, JsonRequestBehavior.AllowGet);
        }
    }
}

