using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.TotalAmountSearchers
{
    public interface IDraftOrderSearcherByTotalAmount
    {
        IEnumerable<DraftOrdersTable> SearchInDraftOrdersByTotalAmount(IEnumerable<DraftOrdersTable> draftOrders, long? minTotalAmount = null, long? maxTotalAmount = null);
    }
}
