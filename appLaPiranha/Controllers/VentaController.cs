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
    public class VentaController : Controller
    {
        private readonly ILogger<VentaController> _logger;

        public VentaController(ILogger<VentaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           return View();
        }
    }
}