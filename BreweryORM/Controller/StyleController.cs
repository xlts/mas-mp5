using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreweryORM.Entity;
using BreweryORM.Context;

namespace BreweryORM.Controller
{
    class StyleController
    {
        public BreweryContext db { get; set; }

        public StyleController(BreweryContext ctxt)
        {
            this.db = ctxt;
        }

        public BeerRecipe FindBeerRecipeByStyle(string qualifier)
        {
            var query = from br in db.BeerRecipes
                        where br.Style.Name == qualifier
                        select br;

            return query.FirstOrDefault<BeerRecipe>();
        }
    }
}
