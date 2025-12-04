using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.ProductSearchers
{
    public class DraftOrderSearcherByProductId : IDraftOrderSearcherByProductId
    {
        public IEnumerable<DraftOrdersTable> SearchInDarftOrdersByProductId(IEnumerable<DraftOrdersTable> draftOrders, int? productId = null)
        {
                if (productId == null||productId==0)
                {
                    return draftOrders;
                }
                using (EfUnitOfWork db = new EfUnitOfWork())
                {
                    return draftOrders.Where(d => d.ProductId == productId);
                }
           
        }
    }
}
