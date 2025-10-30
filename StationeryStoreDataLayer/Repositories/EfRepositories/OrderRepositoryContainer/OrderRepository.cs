using Microsoft.EntityFrameworkCore;
using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.Repositories.EfRepositories.GenericRepositoryContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreDataLayer.Repositories.EfRepositories.ProductRepositoryContainer
{
    public class OrderRepository : EfGenericRepository<OrdersTable>, IOrderRepository
    {
        public OrderRepository(DbContext db) : base(db)
        {

        }
    }
}
