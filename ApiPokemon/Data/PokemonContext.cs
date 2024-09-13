using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiPokemon.Models;

namespace ApiPokemon.Data
{
    public class PokemonContext : DbContext
    {
        public PokemonContext (DbContextOptions<PokemonContext> options)
            : base(options)
        {
        }

        public DbSet<ApiPokemon.Models.Pokemon> Pokemon { get; set; } = default!;
    }
}
