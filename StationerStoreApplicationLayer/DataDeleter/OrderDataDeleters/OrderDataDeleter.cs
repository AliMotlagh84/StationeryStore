using StationerStoreApplicationLayer.DataDeleter.OrdersDataDeleters;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.DataDeleter.OrderDataDeleters
{
    public class OrderDataDeleter : IOrderDataDeleter
    {
        public void DeleteOrderData(OrdersTable order)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.OrderRepository.Delete(order);
                db.Save();
            }
        }

        public void DeleteOrderData(object orderId)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.OrderRepository.Delete(orderId);
                db.Save();
            }
        }
    }
}
