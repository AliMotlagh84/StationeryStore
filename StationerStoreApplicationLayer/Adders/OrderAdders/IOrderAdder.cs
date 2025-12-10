using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Adders.OrderAdders
{
    public interface IOrderAdder
    {
        void AddOrder(OrdersTable order);
    }
}
