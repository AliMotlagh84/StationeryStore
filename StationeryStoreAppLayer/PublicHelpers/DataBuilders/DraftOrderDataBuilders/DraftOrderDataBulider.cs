using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.AmountSearchers;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataBuilders.DraftOrderDataBuilders
{
    public class DraftOrderDataBulider : IDraftOrderDataBuilder
    {
        public DraftOrdersTable BuildDraftOrderData(UserTable orderer, ProductsTable productInfo , int requestedCount,int? DraftOrderIdForEdit=null)
        {
            var draftOrder = new DraftOrdersTable()
            {
                UserId = orderer.UserId,
                UserName = orderer.UserName,
                ProductId = productInfo.ProductId,
                ProductName = productInfo.ProductName,
                BrandId = productInfo.BrandId,
                BrandName = productInfo.BrandName,
                Amount = productInfo.Amount,
                RequestedCount = requestedCount,
                TotalAmount = requestedCount * productInfo.Amount
            };
            if (DraftOrderIdForEdit != null) {
                draftOrder.DraftOrderId = (int)DraftOrderIdForEdit;
            }
            return draftOrder;

        }

    }
}
