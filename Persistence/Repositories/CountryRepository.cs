using Models;
using Persistence.Contexts;
using Persistence.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(AplicationDbContext db) : base(db)
        {
        }

        //    public async Task Update(int id, Country entity)
        //    {
        //        if (entity is null) return;
        //        var edit = await this.Get(id);
        //        if (edit is null) return;
        //        edit.CountryCode = entity.CountryCode;
        //        edit.Name = edit.Name;
        //        await this.Submit();
        //    }
    }
}
