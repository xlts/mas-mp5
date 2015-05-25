using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreweryORM.Context;
using BreweryORM.Entity;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace BreweryORM
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<BreweryContext>());

            using (var db = new BreweryContext()) 
            {
                var pilsRecipe = new BeerRecipe { Name = "Pils Recipe" };
                var pilsOne = new Beer { Name = "PilsOne", BrewingDate = DateTime.Now };
                var pilsTwo = new Beer { Name = "PilsTwo", BrewingDate = DateTime.Now };

                db.BeerRecipes.Add(pilsRecipe);
                db.Beers.Add(pilsOne);
                db.Beers.Add(pilsTwo);

                pilsOne.BeerRecipe = pilsRecipe;
                pilsTwo.BeerRecipe = pilsRecipe;
                
                
                db.SaveChanges();

                Console.WriteLine("finished");

            }
        }
    }
}
