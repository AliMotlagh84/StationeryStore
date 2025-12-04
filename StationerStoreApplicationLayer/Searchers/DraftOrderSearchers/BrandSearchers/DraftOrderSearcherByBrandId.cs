using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.BrandSearchers
{
    public class DraftOrderSearcherByBrandId : IDraftOrderSearcherByBrandId
    {
        public IEnumerable<DraftOrdersTable> SearchInDarftOrdersByBrandId(IEnumerable<DraftOrdersTable> draftOrders, int? BrandId = null)
        {
            if (BrandId == null || BrandId == 0)
            {
                return draftOrders;
            }
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                return draftOrders.Where(d => d.BrandId == BrandId);
            }
        }
    }
}
