using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDeliveryWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Ainda tem muito para ser feito aqui";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Como tudo começou...";

            return View();
        }

        public ActionResult Contato()
        {
            ViewBag.Message = "Fale com a gente!";

            return View();
        }

        public ActionResult Produtos()
        {
            ViewBag.Message = "Todos os produtos estão aqui";

            return View();
        }
    }
}
