using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.AmountSearchers
{
    public interface IDraftOrderSearcherByProductAmount
    {
        IEnumerable<DraftOrdersTable> SearchInDraftOrdersByProductAmount(IEnumerable<DraftOrdersTable> draftOrders, long? minAmount = null, long? maxAmount = null);
    }
}
