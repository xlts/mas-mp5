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
    [Table("Hop")]
    public class Hop : Resource
    {
        [Key]
        public int HopID { get; set; }
        [Required]
        public double AlphAcidPercentage { get; set; }
    }
}
