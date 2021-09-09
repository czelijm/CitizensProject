using Models;
using Persistence.Contexts;
using Persistence.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(AplicationDbContext context) : base(context)
        {

        }


    }
}
