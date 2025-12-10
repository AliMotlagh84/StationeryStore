using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByOrderId
{
    public interface IOrderSearcherByOrderId
    {
        IEnumerable<OrdersTable> SearchInOrdersByOrderId(IEnumerable<OrdersTable> orders, int? orderId = null);
    }
}
