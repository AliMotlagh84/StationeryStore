using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByAmount
{
    public class OrderSearcherByAmount : IOrderSearcherByAmount
    {
        public IEnumerable<OrdersTable> SearchInOrdersByAmount(IEnumerable<OrdersTable> orders, long? minAmount = null, long? maxAmount = null)
        {
            if (((minAmount == null || minAmount == 0)&& (maxAmount == null || maxAmount == 0)))
            {
                return orders;
            }
            else if (minAmount == null || minAmount == 0)
            {
                return orders.Where(o => o.Amount <= maxAmount);
            }
            else if (maxAmount == null || maxAmount == 0)
            {
                return orders.Where(o => minAmount <= o.Amount);
            }
            else
            {
                return orders.Where(o => minAmount <= o.Amount).Where(o => o.Amount <= maxAmount);
            }
        }
    }
}
