using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {


        private readonly DbContext _db;

        public Repository(DbContext db)
        {
            _db = db;
        }

        public void Add(TEntity entity)
        {
            _db.Set<TEntity>().Add(entity);
            _db.SaveChanges();
        }

        public async Task<TEntity> Get(int id)
        {
            var result = await _db.Set<TEntity>().FindAsync(id);
            return result;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _db.Set<TEntity>().ToListAsync();
        }

        public void Remove(TEntity entity)
        {
            if (entity is null) return;
            _db.Set<TEntity>().Remove(entity);
            _db.SaveChanges();
        }

        public async Task Submit()
        {
            await _db.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            if (entity is null) return;
            _db.Set<TEntity>().Attach(entity);
            var entry = _db.Entry(entity);
            entry.State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
