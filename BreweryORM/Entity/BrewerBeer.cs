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
    [Table("BrewerBeer")]
    public class BrewerBeer //associative class
    {
        [Key]
        public int BrewerBeerID { get; set; }

        [ForeignKey("BrewerID")]
        public virtual Brewer Brewer { get; set; } //   association with attribute
        public int BrewerID { get; set; }          //  - 

        [ForeignKey("BeerID")]  
        public virtual Beer Beer { get; set; }     //  -
        public int BeerID { get; set; }            //  -
        
        [Required]                      
        public DateTime BrewingDate { get; set; }
    }
}
