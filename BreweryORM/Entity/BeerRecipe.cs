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
    [Table("BeerRecipe")]
    public partial class BeerRecipe
    {

        [Key]
        public int BeerRecipeID { get; set; }
        
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

        //many-to-one
        public virtual ICollection<Beer> Beers { get; set; }

        //many-to-many
        public virtual ICollection<Resource> Resources { get; set; }

        //qualified association
        [ForeignKey("StyleName")]
        public virtual Style Style { get; set; } 
        public string StyleName { get; set; }

        //composition
        public Yeast Yeast { get; set; }

        public BeerRecipe()
        {
            Yeast = new Yeast(); //complex type Yeast cannot be null
            this.Resources = new HashSet<Resource>();
        }

    }
}
