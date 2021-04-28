using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;
using Pokedex.data;
using System.Collections.Generic;
using System.Linq;

namespace Pokedex.Controllers
{
    public class PokemonController : Controller
    {
        private pokedexContext _context;
        public PokemonController(PokedexContext context)
        {
            _context = context;
            
        }
        public IActionResult Nuevo(){
            return View();

        }  
        [HttpPost]
        public IActionResult Nuevo(Pokemon p){
            if (ModelState.IsValid){
                _context.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Lista");
            }
            return View(p);
        }  

        public IActionResult Lista(){
            var pokemones =  _context.Pokemones.OrderBy(x => x.Nombre).ToList();
            return View(pokemones);
            
        }
    }
}