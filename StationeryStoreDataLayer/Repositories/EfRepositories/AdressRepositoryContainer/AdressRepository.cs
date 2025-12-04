using Microsoft.EntityFrameworkCore;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.Repositories.EfRepositories.GenericRepositoryContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreInfrastructureLayer.Repositories.EfRepositories.ProductRepository
{
    public class AdressRepository : EfGenericRepository<AdressTable>, IAdressRepository
    {
        public AdressRepository(DbContext db) : base(db)
        {

        }
    }
}
