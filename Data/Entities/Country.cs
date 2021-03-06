using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Demo.Data.Entities
{
    [Table("Country")]
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string? CountryName { get; set; }

        public virtual ICollection<City>? City { get; set; }
       
    }
}