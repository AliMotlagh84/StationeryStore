using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.ProductSearchers
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
