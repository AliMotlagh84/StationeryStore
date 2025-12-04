using Microsoft.EntityFrameworkCore;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.Repositories.EfRepositories.GenericRepositoryContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreInfrastructureLayer.Repositories.EfRepositories.BrandRepositoryContiner
{
    public class BrandRepository : EfGenericRepository<BrandsTable>, IBrandRepository
    {
        public BrandRepository(DbContext db) : base(db)
        {
        
        }
    }
}
