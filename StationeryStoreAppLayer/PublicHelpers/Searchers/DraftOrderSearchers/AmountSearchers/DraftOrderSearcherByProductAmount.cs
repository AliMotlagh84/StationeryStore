using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.AmountSearchers
{
    public class DraftOrderSearcherByProductAmount : IDraftOrderSearcherByProductAmount
    {
        public IEnumerable<DraftOrdersTable> SearchInDraftOrdersByProductAmount(IEnumerable<DraftOrdersTable> draftOrders, long? minAmount = null, long? maxAmount = null)
        {
            if (((maxAmount == 0) || (maxAmount == null)) && ((minAmount == 0) || (minAmount == null)))
            {
                return draftOrders;
            }
            else if ((maxAmount == 0) || (maxAmount == null))
            {
                return draftOrders.Where(p => minAmount <= p.Amount);
            }
            else if ((minAmount == 0) || (minAmount == null))
            {
                return draftOrders.Where(p => p.Amount <= maxAmount);
            }
            else
            {
                return draftOrders.Where(p => minAmount <= p.Amount).Where(p => p.Amount <= maxAmount);
            }
        }
    }
}
