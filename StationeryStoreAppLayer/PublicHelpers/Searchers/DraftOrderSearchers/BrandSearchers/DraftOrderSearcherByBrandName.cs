using Microsoft.IdentityModel.Tokens;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.BrandSearchers
{
    public class DraftOrderSearcherByBrandName : IDraftOrderSearcherByBrandName
    {
        public IEnumerable<DraftOrdersTable> SearchInDarftOrdersByBrandName(IEnumerable<DraftOrdersTable> draftOrders, string? brandName = null)
        {
            if (brandName.IsNullOrEmpty())
            {
                return draftOrders;
            }
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                return draftOrders.Where(d => d.BrandName.Contains(brandName));
            }
        }
    }
}
