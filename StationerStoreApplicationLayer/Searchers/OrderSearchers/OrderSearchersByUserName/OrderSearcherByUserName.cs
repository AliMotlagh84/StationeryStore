using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByUserName
{
    public class OrderSearcherByUserName : IOrderSearcherByUserName
    {
        public IEnumerable<OrdersTable> SearchInOrdersByUserName(IEnumerable<OrdersTable> orders, string? userName = null)
        {
            if (userName == null)
            {
                return orders;
            }
            return orders.Where(o => o.UserName.Contains(userName));
        }
    }
}
