using ChessWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChessWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Jugada jugada = new Jugada();

            List<SelectListItem> listaFichas = new List<SelectListItem>();

            listaFichas.Add(
                new SelectListItem()
                {
                    Text = "TORRE", 
                    Value = "3"                    
                }
            );

            listaFichas.Add(
                new SelectListItem()
                {
                    Text = "ALFIL",
                    Value = "5"
                }
            );

            jugada.TiposFichas = listaFichas;

            return View(jugada);
        }

        //public JsonResult Jugar() { }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}