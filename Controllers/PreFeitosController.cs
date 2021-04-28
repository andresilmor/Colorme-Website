using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colorme.Controllers {
    public class PreFeitosController : Controller {

        [Route("/prefeitos/paraamadrinha")]
        public ActionResult Madrinha() { 
            ViewBag.Name = "Para a Madrinha";
            ViewBag.Description = "Para a Madrinha";
            ViewBag.Keywords = "prendas para madrinha, prendas, Colorme, estampagens";
            return View("Views/Dinamicas/PreFeitos.cshtml"); //Returnar com modelo de madrinha que deverá conter o retorno da base de dados
        }
 
    }
}
