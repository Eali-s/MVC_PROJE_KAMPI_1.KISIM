using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepositoryDal <TEntity> where TEntity : class, new()
    {

        //CRUD
        //Type Name();

        List<TEntity> List(Expression<Func<TEntity, bool>> filter);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        List<TEntity> GetAll();

    }
}
