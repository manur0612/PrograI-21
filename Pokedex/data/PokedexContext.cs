using Microsoft.EntityFrameworkCore;
using Pokedex.Models;

namespace Pokedex.data{

    public class PokedexContext : DbContext
    {
        public DbSet<Pokemon> Pokemones { get; set; } 

        public PokedexContext(DbContextOptions dco): base(dco){

        }  
    }
}
