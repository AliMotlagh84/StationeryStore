using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByOrderId
{
    public class OrderSearcherByOrderId : IOrderSearcherByOrderId
    {
        public IEnumerable<OrdersTable> SearchInOrdersByOrderId(IEnumerable<OrdersTable> orders, int? orderId = null)
        {
            if(orderId == null)
            {
                return orders;
            }

            return orders.Where(o => o.OrderId == orderId);
        }
    }
}
