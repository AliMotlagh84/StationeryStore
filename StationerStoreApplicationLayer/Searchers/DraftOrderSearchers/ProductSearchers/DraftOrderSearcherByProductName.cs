using Microsoft.IdentityModel.Tokens;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.ProductSearchers
{
    public class DraftOrderSearcherByProductName : IDraftOrderSearcherByProductName
    {
        public IEnumerable<DraftOrdersTable> SearchInDarftOrdersByProductName(IEnumerable<DraftOrdersTable> draftOrders, string? productName = null)
        {
            if (productName.IsNullOrEmpty())
            {
                return draftOrders;
            }
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                return draftOrders.Where(d => d.ProductName.Contains(productName));
            }

        }
    }
}
