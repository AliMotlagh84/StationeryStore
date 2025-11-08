using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.DraftOrderIdSearchers
{
    public class DraftOrderSearcherByDraftOrderId : IDraftOrderSearcherByDraftOrderId
    {
        public IEnumerable<DraftOrdersTable> SearchInDraftOrderIds(IEnumerable<DraftOrdersTable> draftOrders, int? draftOrderId = null)
        {
            if(draftOrderId == null||draftOrderId==0)
            {
                return draftOrders;
            }
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                return draftOrders.Where(d => d.DraftOrderId==draftOrderId);
            }
        }
    }
}
