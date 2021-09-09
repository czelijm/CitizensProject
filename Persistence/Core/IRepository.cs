using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get(int id);
        Task<IEnumerable<TEntity>> GetAll();
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        Task Submit();

    }
}



//notes

//docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=yourStrongPassword!" -p 1433:1433 --name mssql_1  mcr.microsoft.com/mssql/server
