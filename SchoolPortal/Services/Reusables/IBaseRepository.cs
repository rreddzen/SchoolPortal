using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace SchoolPortal.Services.Reusables
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null,
                              Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                              string includeProperties = "");
        bool IsExisting(T entity);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        void Delete(T entity);
    }
}