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
    [Table("Style")]
    public class Style
    {
        [Key]
        public string Name { get; set; }

        [Required]
        public String Origin { get; set; }

        //qualified association
        public virtual ICollection<BeerRecipe> BeerRecipes { get; set; }

     
    }
}
