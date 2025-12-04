using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.UserSearchers
{
    public interface IDraftOrderSearcherByUserName 
    {
        IEnumerable<DraftOrdersTable> SearchInDraftOrdersByUserName(IEnumerable<DraftOrdersTable> draftOrders,string? userName = null);
    }
}
