using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByDeliveryState
{
    public interface IOrderSearcherByDeliveryState
    {
        IEnumerable<OrdersTable> SearchInOrdersByDeleveryState(IEnumerable<OrdersTable> orders,bool? deliveryState = null);
    }
}
