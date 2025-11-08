using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.UserSearchers
{
    internal class DraftOrderSearcherByUserId : IDraftOrderSearcherByUserId
    {
        public IEnumerable<DraftOrdersTable> SearchInDraftOrdersByUserId(IEnumerable<DraftOrdersTable> draftOrders, int? userId = null)
        {

            {
                if (userId == null || userId==0)
                {
                    return draftOrders;
                }
                using (EfUnitOfWork db = new EfUnitOfWork())
                {
                    return draftOrders.Where(d => d.UserId == userId);
                }


            }
        }
    }
}
