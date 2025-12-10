using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByUserId
{
    public interface IOrderSearcherByUserId
    {
        IEnumerable<OrdersTable> SearchInOrdersByUserId(IEnumerable<OrdersTable> orders, int? userId = null);
    }
}
