using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ABC.Core.Entities;

namespace ABC.Core.DAL
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        T Add(T entity);

        T Update(T entity);

        void Delete(T entity);
    }
}
