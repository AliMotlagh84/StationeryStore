using Microsoft.EntityFrameworkCore.Infrastructure;
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

        public DraftOrdersTable BuildDraftOrderData(int userId, string userName, int productId, string productName, int brandId, string brandName, long productAmount, int requestedCount, int? DraftOrderIdForEdit = null)
        {
            var draftOrder = new DraftOrdersTable()
            {
                UserId = userId,
                UserName = userName,
                ProductId = productId,
                ProductName = productName,
                BrandId = brandId,
                BrandName = brandName,
                Amount = productAmount,
                RequestedCount = requestedCount,
                TotalAmount = requestedCount * productAmount
            };
            if (DraftOrderIdForEdit != null)
            {
                draftOrder.DraftOrderId = (int)DraftOrderIdForEdit;
            }
            return draftOrder;
        }
    }
}
