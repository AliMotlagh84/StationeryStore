using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.ProductSearchers
{
    public interface IDraftOrderSearcherByProductId
    {
        IEnumerable<DraftOrdersTable> SearchInDarftOrdersByProductId(IEnumerable<DraftOrdersTable> draftOrders, int? productId = null);
    }
}
