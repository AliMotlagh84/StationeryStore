using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.RequestedCountSearchers
{
    public interface IDraftOrderSearcherByRequestedCount
    {
        IEnumerable<DraftOrdersTable> SearchInDraftOrdersByRequestedCount(IEnumerable<DraftOrdersTable> draftOrders, int? MinCount = null, int? MaxCount = null);
    }
}
