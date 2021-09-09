using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(255)]
        public string LastName { get; set; }
        [MaxLength(255)]
        public string FirstName { get; set; }
        [MaxLength(255)]
        public string EmailAdress { get; set; }
        [Required]
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
    }
}
