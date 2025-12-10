using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByDeliveryState
{
    public class OrderSearcherByDeliveryState : IOrderSearcherByDeliveryState
    {
        public IEnumerable<OrdersTable> SearchInOrdersByDeleveryState(IEnumerable<OrdersTable> orders, bool? deliveryState = null)
        {
            if (deliveryState == null)
            {
                return orders;
            }

            return orders.Where(o => o.IsDelivered == deliveryState);
        }
    }
}
