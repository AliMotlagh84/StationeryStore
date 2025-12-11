using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.DataDeleter.OrdersDataDeleters
{
    public interface IOrderDataDeleter
    {
        void DeleteOrderData(OrdersTable order);
        void DeleteOrderData(object orderId);
    }
}
