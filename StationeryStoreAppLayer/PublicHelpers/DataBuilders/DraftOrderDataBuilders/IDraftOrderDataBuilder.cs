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
        public DraftOrdersTable BuildDraftOrderData(int userId, string userName, int productId, string productName, int brandId, string brandName, long productAmount, int requestedCount, int? DraftOrderIdForEdit = null);

    }
}
