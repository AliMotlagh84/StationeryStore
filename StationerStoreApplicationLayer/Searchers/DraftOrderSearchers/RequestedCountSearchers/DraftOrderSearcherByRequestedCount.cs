using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.RequestedCountSearchers
{
    public class DraftOrderSearcherByRequestedCount : IDraftOrderSearcherByRequestedCount
    {
        public IEnumerable<DraftOrdersTable> SearchInDraftOrdersByRequestedCount(IEnumerable<DraftOrdersTable> draftOrders, int? MinCount, int? MaxCount)
        {
            if ((MinCount == null || MinCount == 0) && (MaxCount == null || MaxCount == 0))
            {
                return draftOrders;
            }
            else if (MinCount == null || MinCount == 0)
            {
                return draftOrders.Where(d => d.RequestedCount<=MaxCount);
            }
            else if (MaxCount == null || MaxCount == 0)
            {
                return draftOrders.Where(d => MinCount <= d.RequestedCount);
            }
            else
            {
                return draftOrders.Where(d => MinCount <= d.RequestedCount).Where(d => d.RequestedCount <= MaxCount);
            }
        }
    }
}
