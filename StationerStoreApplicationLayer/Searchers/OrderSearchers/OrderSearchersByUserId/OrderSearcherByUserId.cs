using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByUserId
{
    public class OrderSearcherByUserId : IOrderSearcherByUserId
    {
        public IEnumerable<OrdersTable> SearchInOrdersByUserId(IEnumerable<OrdersTable> orders, int? userId = null)
        {
            if(userId == null)
            {
                return orders;
            }

            return orders.Where(o => o.UserId == userId);
        }
    }
}
