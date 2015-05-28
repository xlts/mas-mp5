using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations.Resources;

namespace BreweryORM.Entity
{
    [ComplexType]
    //[Table("Yeast")]
    public class Yeast
    {
        //[Key]
        //public int YeastID { get; set; }

        public string Name { get; set; }
        public double FloculationRate { get; set; }

        //public int BeerRecipeID { get; set; }
        //[ForeignKey("BeerRecipeID")]
        //public virtual BeerRecipe BeerRecipe { get; set; }
    }
}
