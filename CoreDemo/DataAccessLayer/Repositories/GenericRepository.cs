using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<TEntity, TContext> : IGenericDal<TEntity> 
        where TEntity : class, IEntity, new()
        where TContext : Context, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext c = new TContext())
            {
                c.Add(entity);
                c.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext c = new TContext())
            {
                c.Remove(entity);
                c.SaveChanges();
            }
        }

        public List<TEntity> GetListAll()
        {
            using (TContext c = new TContext())
            {
                return c.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using (TContext c = new TContext())
            {
                return c.Set<TEntity>().Find(id);
            }
        }

        public List<TEntity> GetListAll(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext c = new TContext())
            {
                return c.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext c = new TContext())
            {
                c.Update(entity);
                c.SaveChanges();
            }
        }
    }
}
