using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Common.Data.Repository
{
    public interface IBaseRepository<TEntity, TType> where TEntity : class

    {
        void save(TEntity entity);
        void Update(TEntity entity);

        void Remove(TEntity entity);

        List<TEntity> GetAll();

        TEntity GetEntityBy(TType id);

        bool Exists(Expression<Func<TEntity, bool>> filter);

    }
}
