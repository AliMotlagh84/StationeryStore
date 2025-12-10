using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByOrderDate
{
    public interface IOrderSearcherByOrderDate
    {
        IEnumerable<OrdersTable> SearchInOrdersByOrderDate(IEnumerable<OrdersTable> orders,DateTime? minDate = null , DateTime? maxDate = null);
    }
}
