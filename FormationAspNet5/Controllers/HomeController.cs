using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FormationAspNet5.Models;
using FormationAspNet5.Tools;
using FormationAspNet5.Interfaces;

namespace FormationAspNet5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ITestService _uniqueIdService;

        public HomeController(ILogger<HomeController> logger, ITestService uniqueService)
        {
            _logger = logger;
            _uniqueIdService = uniqueService;
        }

        public IActionResult Index()
        {
            ViewBag.uniqueTransientId = _uniqueIdService.UniqueId();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult GetPeron([FromBody] PersonRecord p)
        {
            return Ok();
        }
    }

    
}
