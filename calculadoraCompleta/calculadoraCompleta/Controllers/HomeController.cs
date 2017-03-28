using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace calculadoraCompleta.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string bt, string visor)
        {
            switch (bt) {

                case "0":

                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":

                    // determinar se no Visor só existe um zero
                    if (visor.Equals("0")) visor = bt;
                    else visor += bt; // bisor = visor +bt;

                    break;
            }

            // entregar os valores à VIEW
            ViewBag.Visor = visor;

            return View();
        }

    }
}