using Microsoft.EntityFrameworkCore;
using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.Repositories.EfRepositories.DraftOrderRepository;
using StationeryStoreDataLayer.Repositories.EfRepositories.GenericRepositoryContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreDataLayer.Repositories.EfRepositories.DraftOrderRepositoryContainer
{
    public class DraftOrderRepository : EfGenericRepository<DraftOrdersTable>,IDarftOrderRepository
    {
        public DraftOrderRepository(DbContext db) : base(db)
        {
        }
    }
}
