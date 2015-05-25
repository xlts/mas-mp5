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
    [Table("Yeast")]
    public class Yeast : Resource
    {
        [Key]
        public int YeastID { get; set; }

        [Required]
        public double FloculationRate { get; set; }
    }
}
