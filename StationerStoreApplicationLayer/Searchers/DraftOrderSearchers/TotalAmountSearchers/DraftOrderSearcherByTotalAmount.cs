using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.AmountSearchers;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.TotalAmountSearchers
{
    public class DraftOrderSearcherByTotalAmount : IDraftOrderSearcherByTotalAmount
    {
        public IEnumerable<DraftOrdersTable> SearchInDraftOrdersByTotalAmount(IEnumerable<DraftOrdersTable> draftOrders, long? minTotalAmount = null, long? maxTotalAmount = null)
        {
            if (((minTotalAmount == 0) || (minTotalAmount == null)) && ((maxTotalAmount == 0) || (maxTotalAmount == null)))
            {
                return draftOrders;
            }
            else if ((maxTotalAmount == 0) || (maxTotalAmount == null))
            {
                return draftOrders.Where(d => minTotalAmount <= d.TotalAmount);
            }
            else if ((minTotalAmount == 0) || (minTotalAmount == null))
            {
                return draftOrders.Where(d => d.TotalAmount <= maxTotalAmount);
            }
            else
            {
                return draftOrders.Where(d => minTotalAmount <= d.TotalAmount).Where(d => d.TotalAmount <= maxTotalAmount);
            }
        }
    }
}
