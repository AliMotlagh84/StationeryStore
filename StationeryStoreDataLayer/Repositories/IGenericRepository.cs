using Microsoft.EntityFrameworkCore.Migrations.Operations;
using StationeryStoreInfrastructureLayer.Repositories.EfRepositories.ProductRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreInfrastructureLayer.Repositories
{
    public interface IGenericRepository<T> where T : class 
    {
        List<T> GetAll(Expression<Func<T,bool>> where = null);
        T GetById(object Id);
        void Add(T entity);
        void Delete(T entity);
        void Delete(object Id);
        void Update(T entity);

    }
}
