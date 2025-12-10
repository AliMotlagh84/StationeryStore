using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByUserName
{
    public interface IOrderSearcherByUserName
    {
        IEnumerable<OrdersTable> SearchInOrdersByUserName(IEnumerable<OrdersTable> orders,string? userName = null);
    }
}
