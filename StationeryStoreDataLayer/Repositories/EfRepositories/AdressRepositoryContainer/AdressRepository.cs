using Microsoft.EntityFrameworkCore;
using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.Repositories.EfRepositories.GenericRepositoryContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreDataLayer.Repositories.EfRepositories.ProductRepository
{
    public class AdressRepository : EfGenericRepository<AdressTable>, IAdressRepository
    {
        public AdressRepository(DbContext db) : base(db)
        {

        }
    }
}
