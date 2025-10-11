using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using StationeryStoreDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreDataLayer.Repositories.EfRepositories.GenericRepositoryContainer
{
    public class EfGenericRepository<T> : IGenericRepository<T> where T : class 
    {
        private DbContext db;
        private DbSet<T> dbSet;
        public EfGenericRepository(DbContext db)
        {
            this.db = db;
            dbSet = db.Set<T>();
        }
        public void Add(T entity)
        {
            db.Add(entity);
        }

        public void Delete(T entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
        }

        public void Delete(object Id)
        {
            if (dbSet.Find(Id) != null)
            {
                Delete(dbSet.Find(Id));
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> where = null)
        {
            if (where == null)
            {
                return dbSet.Select(c => c).ToList();
            }

            return dbSet.Where(where).Select(c => c).ToList();

        }

        public T GetById(object Id)
        {
            return dbSet.Find(Id);
        }

        public void Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
