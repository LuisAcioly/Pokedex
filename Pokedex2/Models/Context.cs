using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex2.Models
{
    public class Context : DbContext
    {
        public DbSet<Trainer> Trainers { get; set; }

        public DbSet<Pokemon> Pokemons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Pokedex;Integrated Security=True");
        }
    }
}
