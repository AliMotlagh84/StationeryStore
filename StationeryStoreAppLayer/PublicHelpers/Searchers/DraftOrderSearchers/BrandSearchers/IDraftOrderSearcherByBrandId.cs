using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.BrandSearchers
{
    public interface IDraftOrderSearcherByBrandId
    {
        IEnumerable<DraftOrdersTable> SearchInDarftOrdersByBrandId(IEnumerable<DraftOrdersTable> draftOrders, int? BrandId = null);
    }
}
