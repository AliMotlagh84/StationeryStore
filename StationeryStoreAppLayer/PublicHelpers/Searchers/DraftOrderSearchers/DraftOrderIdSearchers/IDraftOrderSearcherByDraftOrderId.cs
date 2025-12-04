using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.DraftOrderIdSearchers
{
    public interface IDraftOrderSearcherByDraftOrderId
    {
        IEnumerable<DraftOrdersTable> SearchInDraftOrderIds(IEnumerable<DraftOrdersTable> draftOrders,int? draftOrderId = null);
    }
}
