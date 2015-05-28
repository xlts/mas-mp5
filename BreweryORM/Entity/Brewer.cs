using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations.Resources;

using BreweryORM.Entity;
using BreweryORM.Context;

namespace BreweryORM.Entity
{
    [Table("Brewer")]
    public class Brewer
    {
        [Key]
        public int BrewerID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<BrewerBeer> BrewerBeers { get; set; } //association with attribute

        public Brewer()
        {
            this.BrewerBeers = new HashSet<BrewerBeer>();
        }

        internal void AddBeer(Beer b, DateTime date, BreweryContext ctxt)
        {
           
            BrewerBeer bb = new BrewerBeer { Brewer = this, Beer = b, BrewingDate = date };
            BrewerBeers.Add(bb);
            ctxt.BrewerBeers.Add(bb);
            
        }
    }
}
