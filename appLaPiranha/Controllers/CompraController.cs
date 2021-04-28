using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using appLaPiranha.Models;

namespace appLaPiranha.Controllers
{
    public class CompraController : Controller
    {
        private readonly ILogger<CompraController> _logger;

        public CompraController(ILogger<CompraController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}