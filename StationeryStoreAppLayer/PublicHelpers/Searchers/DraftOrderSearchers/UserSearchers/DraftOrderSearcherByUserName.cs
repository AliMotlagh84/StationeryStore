using Microsoft.IdentityModel.Tokens;
using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.Repositories.EfRepositories.DraftOrderRepository;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.UserSearchers
{
    public class DraftOrderSearcherByUserName : IDraftOrderSearcherByUserName
    {
        public IEnumerable<DraftOrdersTable> SearchInDraftOrdersByUserName(IEnumerable<DraftOrdersTable> draftOrders, string? userName = null)
        {

            {
                if (userName.IsNullOrEmpty())
                {
                    return draftOrders;
                }
                using (EfUnitOfWork db = new EfUnitOfWork())
                {
                    return draftOrders.Where(d => d.UserName.Contains(userName));
                }


            }
        }
    }
}

