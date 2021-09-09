using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext() : base()
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Country> Countries { get; set; }
        
        
    }
}
