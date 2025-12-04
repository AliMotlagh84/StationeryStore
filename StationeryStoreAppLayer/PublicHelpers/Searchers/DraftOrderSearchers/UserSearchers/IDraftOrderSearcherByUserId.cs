using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.UserSearchers
{
    public interface IDraftOrderSearcherByUserId
    {
        IEnumerable<DraftOrdersTable> SearchInDraftOrdersByUserId(IEnumerable<DraftOrdersTable> draftOrders, int? userId = null);

    }
}
