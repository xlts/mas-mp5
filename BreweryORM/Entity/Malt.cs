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
    [Table("Malt")]
    public class Malt : Resource
    {
        [Key]
        public int MaltID { get; set; }

        [Required]
        public double ColouringValue { get; set; }
    }
}
