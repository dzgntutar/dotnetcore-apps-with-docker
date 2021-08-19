using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Core.Service
{
    public interface IService<TEntity> where  TEntity:class
    {
        List<TEntity> GetAll();

        void Delete(TEntity entity);

        TEntity Add(TEntity entity);

        TEntity GetSingle(int id);

        TEntity Update(TEntity entity);
    }
}
