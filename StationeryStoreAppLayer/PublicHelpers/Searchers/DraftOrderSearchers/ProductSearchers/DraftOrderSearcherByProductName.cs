using Microsoft.IdentityModel.Tokens;
using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.ProductSearchers
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
