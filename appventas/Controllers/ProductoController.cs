using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using appventas.Models;

namespace appventas.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;

        public ProductoController(ILogger<ProductoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult MiMetodoExecute(Producto objProducto)
        {
            Double total = 0.0;
            Double result = 0.0;
            String message ="";
            if(objProducto.Cantidad == 0){
                message ="La cantidad no puede ser 0";
                if(objProducto.Precio == 0){
                message ="El Precio no puede ser 0";
            }else{
                    total = objProducto.Cantidad * objProducto.Precio;
                    result = total * 1.18;
                    message ="El Total + IGV es " + result;
                }         
            }
            ViewData["Message"] = message;
            return View("Index");
        }

    }
}
