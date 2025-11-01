using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataBuilders.DraftOrderDataBuilders
{
    public interface IDraftOrderDataBuilder
    {
        DraftOrdersTable BuildDraftOrderData(UserTable orderer,ProductsTable productInfo, int requestedCount,int? DraftOrderIdForEdit=null);
    }
}
