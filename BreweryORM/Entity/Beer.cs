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
    [Table("Beer")]
    public class Beer
    {
        [Key]
        public int BeerID { get; set; }
       
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

 
        //one-to-many
        public int BeerRecipeID { get; set; }
        [ForeignKey("BeerRecipeID")]
        public virtual BeerRecipe BeerRecipe { get; set; }

        public virtual ICollection<BrewerBeer> BrewerBeers { get; set; } //association with attribute

        
    }
}
