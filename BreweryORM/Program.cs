using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BreweryORM.Context;
using BreweryORM.Entity;
using BreweryORM.Controller;

using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace BreweryORM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<BreweryContext>());

            using (BreweryContext db = new BreweryContext()) 
            {
                Style czechPilsner = new Style { Name = "Bohemian Pilsner", Origin = "Czech Republic" };
                db.Styles.Add(czechPilsner);
             
                BeerRecipe pilsRecipe = new BeerRecipe { BeerRecipeID = 1, Name = "Pils Recipe", Style = czechPilsner, Yeast = new Yeast { Name = "Saflager S-33", FloculationRate = 0.85 } };
                Beer pilsOne = new Beer { Name = "PilsOne" };
                Beer pilsTwo = new Beer { Name = "PilsTwo" };

                db.BeerRecipes.Add(pilsRecipe);
                db.Beers.Add(pilsOne);
                db.Beers.Add(pilsTwo);

                pilsOne.BeerRecipe = pilsRecipe;
                pilsTwo.BeerRecipe = pilsRecipe;

                Malt pilsnerMalt = new Malt { Name = "Pilsner Malt", ColouringValue = 3.5 };
                Hop saaz = new Hop { Name = "Saaz", AlphAcidPercentage = 4.2 };

                db.Resources.Add(pilsnerMalt);
                db.Resources.Add(saaz);

                pilsRecipe.Resources.Add(pilsnerMalt);
                pilsRecipe.Resources.Add(saaz);

                Brewer john = new Brewer { Name = "John" };
                BrewerBeer john_pilsOne = new BrewerBeer { Beer = pilsOne, Brewer = john, BrewingDate = DateTime.Today };

                db.Brewers.Add(john);

                john.AddBeer(pilsOne, DateTime.Today, db);

                StyleController styleController = new StyleController(db);

                db.SaveChanges();

                Console.WriteLine("Recipe by Bohemian Pilsner style");
                Console.WriteLine(styleController.FindBeerRecipeByStyle("Bohemian Pilsner").Name);


                Console.WriteLine("finished");

            }
        }
    }
}
