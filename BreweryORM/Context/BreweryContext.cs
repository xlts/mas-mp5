using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BreweryORM.Entity;

namespace BreweryORM.Context
{
    class BreweryContext : DbContext
    {
       protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hop>().Map(m =>
            {
              m.MapInheritedProperties();
            });

             modelBuilder.Entity<Yeast>().Map(m =>
             {
                 m.MapInheritedProperties();
             });

        }

        public DbSet<Beer> Beers { get; set; }
        public DbSet<BeerRecipe> BeerRecipes { get; set; }
        public DbSet<Resource> Resources { get; set; }
    }
}
