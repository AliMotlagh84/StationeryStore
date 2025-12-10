using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.DataAdders.OrderDataAdders
{
    public class OrderDataAdder : IOrderDataAdder
    {
        public void AddOrderData(OrdersTable newOrders)
        {
            using(EfUnitOfWork db = new EfUnitOfWork())
            {
                db.OrderRepository.Add(newOrders);
                db.Save();
            }
        }
    }
}
