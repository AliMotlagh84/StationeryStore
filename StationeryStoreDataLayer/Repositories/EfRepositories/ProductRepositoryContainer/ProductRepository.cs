using Microsoft.EntityFrameworkCore;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.Repositories.EfRepositories.GenericRepositoryContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreInfrastructureLayer.Repositories.EfRepositories.ProductRepositoryContainer
{
    public class ProductRepository : EfGenericRepository<ProductsTable>, IProductRepository
    {
        public ProductRepository(DbContext db) : base(db)
        {

        }
    }
}
