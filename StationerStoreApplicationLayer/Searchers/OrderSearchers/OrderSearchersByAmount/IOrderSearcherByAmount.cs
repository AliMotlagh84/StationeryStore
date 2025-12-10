using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByAmount
{
    public interface IOrderSearcherByAmount
    {
        IEnumerable<OrdersTable> SearchInOrdersByAmount(IEnumerable<OrdersTable> orders, long? minAmount = null, long? maxAmount = null);
    }
}
