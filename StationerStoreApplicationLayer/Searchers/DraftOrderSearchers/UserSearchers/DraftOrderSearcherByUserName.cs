using Microsoft.IdentityModel.Tokens;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.Repositories.EfRepositories.DraftOrderRepository;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.UserSearchers
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

