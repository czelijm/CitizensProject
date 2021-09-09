using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Country
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(3)]
        public string CountryCode { get; set; }


    }
}
