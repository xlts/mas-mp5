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
    [Table("Beer Recipe")]
    public class BeerRecipe
    {
        [Key]
        public int BeerRecipeID { get; set; }
        
        [Column("Name")]
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Beer> Beers { get; set; }

        //many-to-many
        public virtual ICollection<Resource> Resources { get; set; }
    }
}
