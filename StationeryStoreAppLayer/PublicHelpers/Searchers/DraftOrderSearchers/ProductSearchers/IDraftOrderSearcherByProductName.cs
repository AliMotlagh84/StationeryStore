using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.ProductSearchers
{
    public interface IDraftOrderSearcherByProductName
    {
        public IEnumerable<DraftOrdersTable> SearchInDarftOrdersByProductName(IEnumerable<DraftOrdersTable> draftOrders, string? productName = null);

    }
}
