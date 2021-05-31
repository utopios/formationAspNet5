﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FormationAspNet5.Models;
using FormationAspNet5.Tools;
using FormationAspNet5.Interfaces;
using FormationAspNet5.Services;

namespace FormationAspNet5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ITestTransientService _uniqueIdServiceTransient;
        private ITestScopedService _uniqueIdServiceScoped;
        private ITestSignletonService _uniqueIdServiceSingleton;
        private SecondService _secondService;

        public HomeController(ILogger<HomeController> logger, ITestTransientService uniqueServiceTransient, ITestSignletonService uniqueIdServiceSingleton, ITestScopedService uniqueIdServiceScoped, SecondService secondService)
        {
            _logger = logger;
            _uniqueIdServiceTransient = uniqueServiceTransient;
            _uniqueIdServiceSingleton = uniqueIdServiceSingleton;
            _uniqueIdServiceScoped = uniqueIdServiceScoped;
            _secondService = secondService;
        }

        public IActionResult Index()
        {
            ViewBag.uniqueTransientId = _uniqueIdServiceTransient.UniqueId();
            ViewBag.uniqueSingletonId = _uniqueIdServiceSingleton.UniqueId();
            ViewBag.uniqueScopedId = _uniqueIdServiceScoped.UniqueId();
            ViewBag.secondId = _secondService.getId();
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
