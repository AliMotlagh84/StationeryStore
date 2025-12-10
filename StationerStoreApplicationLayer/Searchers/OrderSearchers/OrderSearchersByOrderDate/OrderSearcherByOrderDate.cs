using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByOrderDate
{
    public class OrderSearcherByOrderDate : IOrderSearcherByOrderDate
    {
        public IEnumerable<OrdersTable> SearchInOrdersByOrderDate(IEnumerable<OrdersTable> orders, DateTime? minDate = null, DateTime? maxDate = null)
        {
            if (minDate == null && maxDate == null)
            {
                return orders;
            }
            else if (maxDate == null)
            {
                return orders.Where(o => minDate <= o.Date);
            }
            else if (minDate == null)
            {
                return orders.Where(o => o.Date <= maxDate);
            }
            else
            {
                return orders.Where(o => minDate <= o.Date).Where(o => o.Date <= maxDate);
            }
        }
    }
}
