using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        List<T> GetAllBind();
        T GetById(params object[] id);

        T Add(T entity);
        T SubmitOnAdd(T entity);

        T Delete(T entity);
        T SubmitOnDelete(T entity);

        void Edit(T entity);
        void SubmitOnEdit(T entity);

        void Save();
    }
}
