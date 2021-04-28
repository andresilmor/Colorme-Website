using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colorme.Controllers {
    public class ErrorController : Controller {

        [Route("Error/{statusCode}")]
        public ActionResult HttpStatusCodeHandler(int statusCode) {
            switch(statusCode) {
                case 404:
                    ViewBag.ErrorMessage="fdasda";
                    break;

            }

            return View("NotFound");
        }
    }
}
