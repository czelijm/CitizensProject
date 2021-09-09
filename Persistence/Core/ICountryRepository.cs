using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Persistence.Core
{
    public interface ICountryRepository : IRepository<Country>
    {
       //Task Update(int id, Country entity);
    }
}
