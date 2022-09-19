using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class GenericRepository<TEntity> : IRepositoryDal<TEntity> where TEntity : class, new()
    {
        Context context = new Context();
        DbSet<TEntity> _object;

        public GenericRepository()
        {
            _object = context.Set<TEntity>();
        }
        public void Delete(TEntity entity)
        {


            //var deletedEntity = context.Entry(category);
            //deletedEntity.State = EntityState.Deleted;
            //context.SaveChanges();
            _object.Remove(entity);
            context.SaveChanges();


        }

        public List<TEntity> GetAll()
        {
            return _object.ToList();
        }

        public void Insert(TEntity entity)
        {


            //var addedEntity = context.Entry(category);
            //addedEntity.State = EntityState.Added;
            //context.SaveChanges();
            _object.Add(entity);
            context.SaveChanges();

        }


        public void Update(TEntity category)
        {


            //var updatedEntity = context.Entry(category);
            //updatedEntity.State = EntityState.Modified;
            //context.SaveChanges();

            context.SaveChanges();



        }

        List<TEntity> IRepositoryDal<TEntity>.List(Expression<Func<TEntity, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }
    }
}
