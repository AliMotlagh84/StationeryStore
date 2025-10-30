using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataGeters.OrdersGeters
{
    public class OrdersDataGeter : IOrdersDataGeter
    {
        public List<OrdersTable> GetOrdersData()
        {
            using(EfUnitOfWork db = new EfUnitOfWork())
            {
             return   db.OrderRepository.GetAll();
            }
        }
    }
}
