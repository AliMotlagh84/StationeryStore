using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Deleters.OrderDeleters
{
    public interface IOrderDeleter
    {
        void DeleteOrder(OrdersTable order);
    }
}
