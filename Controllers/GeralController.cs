using Colorme.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Colorme.Controllers {

    // Todas as páginas que não pertencam a um "núcleo"
    public class GeralController : Controller {
        private readonly ILogger<GeralController> _logger;

        public GeralController(ILogger<GeralController> logger) {
            _logger = logger;
        }

        [Route("/")]
        public IActionResult Index() {
            return View("Views/Geral/Index.cshtml");
        }

        [Route("/privacidade")]
        public IActionResult Privacy() {
            return View("Views/Geral/Privacy.cshtml");
        }

        [Route("/sobrenos")]
        public IActionResult SobreNos() {
            return View("Views/Geral/SobreNos.cshtml");
        }

        [Route("/portfolio")]
        public IActionResult Portfolio() {
            return View("Views/Geral/Portfolio.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
