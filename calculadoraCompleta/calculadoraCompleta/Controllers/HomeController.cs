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

        public ActionResult Index() {

            ViewBag.Visor = "0";

            return View();
        }

        // POST : Home
        // variáveis globais
        string op1, op2, operador;

        [HttpPost]
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

                case ",":

                    if (!visor.Contains(",")) visor += ",";
                    break;

                case "+/-":

                    //visor = Convert.ToDouble(visor) * -1 + "";
                    // só para introduzir a manipulação de strings
                    if (visor.StartsWith("-")) visor = visor.Replace("-", "");
                    else 
                        if(!visor.Contains("0"))
                            visor = "-" + visor;
                    break;
                case "C":
                    visor = "0";
                    Session["PrimeiroOperador"] = true;
                    break;
                case "+":

                    break;
                case "-":

                    break;
                case "X":

                    break;
                case ":":

                    if ((bool)Session["PrimeiroOperador"])
                    {

                        // guardar valor VISOR
                        Session["operando"] = visor;

                        // limpar VISOR
                        visor = "0";

                        // guardar o OPERADOR
                        Session["operando"] = bt;

                        // marcar como tendo utilizafdo o operador

                        Session["PrimeiroOperador"] = false;
                    }
                    else
                    {

                        // se não é a primeira vez que se clica num OPERADOR 
                        // vou utilizar os valore anteriores
                        switch ((string)Session["operador"])
                        {

                            // recuperar código da 1ª calculadora
                            case "":
                                break;
                        }

                        // guardar novos elementos
                    }

                    break;

            }

            // entregar os valores à VIEW
            ViewBag.Visor = visor; 

            return View();
        }

    }
}