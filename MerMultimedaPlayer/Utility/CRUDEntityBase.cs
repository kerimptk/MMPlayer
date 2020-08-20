using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MerMultimedaPlayer.Utility
{
    public class CRUDEnitityBase<TEntity, TContext> : ICrudEntity<TEntity>
        where TEntity : class, new()
        where TContext : DbContext, new()
    {
        // Bağlantılı 
        private TContext _context;

        public CRUDEnitityBase()
        {
            _context = new TContext();
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            var update = _context.Entry<TEntity>(entity);
            update.State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IList<TEntity> Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().Where(filter).ToList();
        }

        public IList<TEntity> GetList(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? _context.Set<TEntity>().ToList()
                : _context.Set<TEntity>().Where(filter).ToList();
        }
    }
}
