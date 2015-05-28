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
        public DbSet<Beer> Beers { get; set; }
        public DbSet<BeerRecipe> BeerRecipes { get; set; }
        public DbSet<Brewer> Brewers { get; set; }
        public DbSet<BrewerBeer> BrewerBeers { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<Resource> Resources { get; set; }

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Types<BeerRecipe>()
             .Configure(ctc => ctc.Property(br => br.Yeast.Name).HasColumnName("Name"));
        }

       
    }
}
