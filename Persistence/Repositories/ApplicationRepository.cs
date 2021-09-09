using Persistence.Contexts;
using Persistence.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ApplicationRepository : IDisposable
    {
        private readonly AplicationDbContext _db;
        public ICountryRepository Countries { get; private set; }
        public IPersonRepository People { get; private set; }


        public ApplicationRepository(AplicationDbContext context)
        {
            _db = context;
            Countries = new CountryRepository(_db);
            People = new PersonRepository(_db);
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
