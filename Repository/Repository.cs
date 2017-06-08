using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Repository
{
    public class Repository<C, T> : IRepository<T> where T : class where C : DbContext, new()
    {
        C ctx;
        DbSet<T> set;

        public Repository(C ctx)
        {
            this.ctx = ctx;
            set = ctx.Set<T>();
        }

        public virtual IQueryable<T> GetAll()
        {
            IQueryable<T> query = set;
            return query;
        }
        public List<T> GetAllBind()
        {
            return GetAll().ToList();
        }
        public virtual T GetById(params object[] ids)
        {
            T entity = set.Find(ids);
            return entity;
        }
        public virtual T Add(T entity)
        {
            T result = set.Add(entity);
            return result;
        }
        public T SubmitOnAdd(T entity)
        {
            T result = Add(entity);
            ctx.SaveChanges();
            return result;
        }

        public virtual T Delete(T entity)
        {
            T result = set.Remove(entity);
            return result;
        }
        public T SubmitOnDelete(T entity)
        {
            T result = Delete(entity);
            ctx.SaveChanges();
            return result;
        }

        public virtual void Edit(T entity)
        {
            ctx.Entry(entity).State = EntityState.Modified;
        }
        public void SubmitOnEdit(T entity)
        {
            Edit(entity);
            ctx.SaveChanges();
        }
        public virtual void Save()
        {
            ctx.SaveChanges();
        }
    }
}
