using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.AmountSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.BrandSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.DraftOrderIdSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.ProductSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.RequestedCountSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.TotalAmountSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.UserSearchers;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers
{
    public class DraftOrderSearcher : IDraftOrderSearcher ,
        IDraftOrderSearcherByDraftOrderId,
        IDraftOrderSearcherByUserId,
        IDraftOrderSearcherByUserName,
        IDraftOrderSearcherByBrandId,
        IDraftOrderSearcherByBrandName,
        IDraftOrderSearcherByProductId,
        IDraftOrderSearcherByProductName,
        IDraftOrderSearcherByProductAmount,
        IDraftOrderSearcherByTotalAmount,
        IDraftOrderSearcherByRequestedCount

    {
        private IEnumerable<DraftOrdersTable> draftOrders;
        private IDraftOrderSearcherByDraftOrderId _draftOrderSearcherByDraftOrderId;
        private IDraftOrderSearcherByUserId _draftOrderSearcherByUserId;
        private IDraftOrderSearcherByUserName _draftOrderSearcherByUserName;
        private IDraftOrderSearcherByBrandId _draftOrderSearcherByBrandId;
        private IDraftOrderSearcherByBrandName _draftOrderSearcherByBrandName;
        private IDraftOrderSearcherByProductId _draftOrderSearcherByProductId;
        private IDraftOrderSearcherByProductName _draftOrderSearcherByProductName;
        private IDraftOrderSearcherByProductAmount _draftOrderSearcherByProductAmount;
        private IDraftOrderSearcherByTotalAmount _draftOrderSearcherByTotalAmount;
        private IDraftOrderSearcherByRequestedCount _draftOrderSearcherByRequestedCount;

        public DraftOrderSearcher(
            IDraftOrderSearcherByDraftOrderId draftOrderSearcherByDraftOrderId,
            IDraftOrderSearcherByUserId draftOrderSearcherByUserId,
            IDraftOrderSearcherByUserName draftOrderSearcherByUserName,
            IDraftOrderSearcherByBrandId draftOrderSearcherByBrandId,
            IDraftOrderSearcherByBrandName draftOrderSearcherByBrandName,
            IDraftOrderSearcherByProductId draftOrderSearcherByProductId,
            IDraftOrderSearcherByProductName draftOrderSearcherByProductName,
            IDraftOrderSearcherByProductAmount draftOrderSearcherByProductAmount,
            IDraftOrderSearcherByTotalAmount draftOrderSearcherByTotalAmount,
            IDraftOrderSearcherByRequestedCount draftOrderSearcherByRequestedCount
            )
        {
            _draftOrderSearcherByDraftOrderId = draftOrderSearcherByDraftOrderId;
            _draftOrderSearcherByUserId = draftOrderSearcherByUserId;
            _draftOrderSearcherByUserName = draftOrderSearcherByUserName;
            _draftOrderSearcherByBrandId = draftOrderSearcherByBrandId;
            _draftOrderSearcherByBrandName = draftOrderSearcherByBrandName;
            _draftOrderSearcherByProductId = draftOrderSearcherByProductId;
            _draftOrderSearcherByProductName = draftOrderSearcherByProductName;
            _draftOrderSearcherByProductAmount = draftOrderSearcherByProductAmount;
            _draftOrderSearcherByTotalAmount = draftOrderSearcherByTotalAmount;
            _draftOrderSearcherByRequestedCount = draftOrderSearcherByRequestedCount;
            
        }

        public List<DraftOrdersTable> SearchInDraftOrders(IEnumerable<DraftOrdersTable> draftOrders, int? id = null, int? userId = null, string? userName = null, int? prductId = null, string? productName = null, int? brandId = null, string? brandName = null, int? minRequestedCount = null, int? maxRequestedCount = null, long? minAmount = null, long? maxAmount = null, long? minTotalAmount = null, long? maxTotalAmount = null)
        {
            this.draftOrders = draftOrders;
            var userNameFiltered = SearchInDraftOrdersByUserName(draftOrders,userName);
            var userIdFiltered = SearchInDraftOrdersByUserId(userNameFiltered, userId);
            var brandNameFiltered = SearchInDarftOrdersByBrandName(userIdFiltered, brandName);
            var brandIdFiltered = SearchInDarftOrdersByBrandId(brandNameFiltered, brandId);
            var productNameFiltered = SearchInDarftOrdersByProductName(brandIdFiltered, productName);
            var productIdFitered = SearchInDarftOrdersByProductId(productNameFiltered,prductId);
            var productAmountFiltered = SearchInDraftOrdersByProductAmount(productIdFitered,minAmount,maxAmount);
            var requstedCountFiltered = SearchInDraftOrdersByRequestedCount(productAmountFiltered,minRequestedCount,maxRequestedCount);
            var filtered = SearchInDraftOrdersByTotalAmount(requstedCountFiltered,minTotalAmount,maxTotalAmount);
            return filtered.ToList();
        }

        public IEnumerable<DraftOrdersTable> SearchInDarftOrdersByBrandId(IEnumerable<DraftOrdersTable> draftOrders, int? BrandId = null)
        {
            return _draftOrderSearcherByBrandId.SearchInDarftOrdersByBrandId(draftOrders, BrandId);
        }

        public IEnumerable<DraftOrdersTable> SearchInDarftOrdersByBrandName(IEnumerable<DraftOrdersTable> draftOrders, string? brandName = null)
        {
            return _draftOrderSearcherByBrandName.SearchInDarftOrdersByBrandName(draftOrders, brandName);
        }

        public IEnumerable<DraftOrdersTable> SearchInDarftOrdersByProductId(IEnumerable<DraftOrdersTable> draftOrders, int? productId = null)
        {
            return _draftOrderSearcherByProductId.SearchInDarftOrdersByProductId(draftOrders, productId);
        }

        public IEnumerable<DraftOrdersTable> SearchInDarftOrdersByProductName(IEnumerable<DraftOrdersTable> draftOrders, string? productName = null)
        {
            return _draftOrderSearcherByProductName.SearchInDarftOrdersByProductName(draftOrders,productName);
        }

        public IEnumerable<DraftOrdersTable> SearchInDraftOrderIds(IEnumerable<DraftOrdersTable> draftOrders, int? draftOrderId = null)
        {
            return _draftOrderSearcherByDraftOrderId.SearchInDraftOrderIds(draftOrders, draftOrderId);
        }

        public IEnumerable<DraftOrdersTable> SearchInDraftOrdersByProductAmount(IEnumerable<DraftOrdersTable> draftOrders, long? minAmount = null, long? maxAmount = null)
        {
            return _draftOrderSearcherByProductAmount.SearchInDraftOrdersByProductAmount(draftOrders, minAmount, maxAmount);
        }

        public IEnumerable<DraftOrdersTable> SearchInDraftOrdersByRequestedCount(IEnumerable<DraftOrdersTable> draftOrders, int? MinCount = null, int? MaxCount = null)
        {
            return _draftOrderSearcherByRequestedCount.SearchInDraftOrdersByRequestedCount(draftOrders,MinCount,MaxCount);
        }

        public IEnumerable<DraftOrdersTable> SearchInDraftOrdersByTotalAmount(IEnumerable<DraftOrdersTable> draftOrders, long? minTotalAmount = null, long? maxTotalAmount = null)
        {
            return _draftOrderSearcherByTotalAmount.SearchInDraftOrdersByTotalAmount(draftOrders,minTotalAmount,maxTotalAmount);
        }

        public IEnumerable<DraftOrdersTable> SearchInDraftOrdersByUserId(IEnumerable<DraftOrdersTable> draftOrders, int? userId = null)
        {
            return _draftOrderSearcherByUserId.SearchInDraftOrdersByUserId(draftOrders,userId);
        }

        public IEnumerable<DraftOrdersTable> SearchInDraftOrdersByUserName(IEnumerable<DraftOrdersTable> draftOrders, string? userName = null)
        {
            return _draftOrderSearcherByUserName.SearchInDraftOrdersByUserName(draftOrders,userName);
        }

        List<DraftOrdersTable> IDraftOrderSearcher.SearchInDraftOrders(IEnumerable<DraftOrdersTable> draftOrders, int? id, int? userId, string? userName, int? prductId, string? productName, int? brandId, string? brandName, int? minRequestedCount, int? maxRequestedCount, long? minAmount, long? maxAmount, long? minTotalAmount, long? maxTotalAmount)
        {
            return SearchInDraftOrders(draftOrders, id, userId, userName, prductId, productName, brandId, brandName, minRequestedCount, maxRequestedCount, minAmount, maxAmount, minTotalAmount, maxTotalAmount);
        }
    }
}
