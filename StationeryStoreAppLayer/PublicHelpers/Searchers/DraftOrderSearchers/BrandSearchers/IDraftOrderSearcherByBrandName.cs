using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.BrandSearchers
{
    public interface IDraftOrderSearcherByBrandName
    {
        public IEnumerable<DraftOrdersTable> SearchInDarftOrdersByBrandName(IEnumerable<DraftOrdersTable> draftOrders, string? brandName = null);

    }
}
