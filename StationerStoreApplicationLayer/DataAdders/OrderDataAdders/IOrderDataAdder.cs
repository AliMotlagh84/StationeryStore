using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.DataAdders.OrderDataAdders
{
    public interface IOrderDataAdder
    {
        void AddOrderData(OrdersTable newOrders);
    }
}
