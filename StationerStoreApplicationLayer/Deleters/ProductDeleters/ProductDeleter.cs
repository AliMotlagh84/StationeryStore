using StationeryStoreUILayer.PublicHelpers.DataAdders.DraftOrderSenders;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.DraftOrderDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.ProductDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Deleters.ProductDeleters
{
    public class ProductDeleter : IProductDeleter, IProductDataDeleter, IDraftOrderDataGeter, IDraftOrderSearcher, IDraftOrderDataDeleter
    {

        private IProductDataDeleter _productDataDeleter;
        private IDraftOrderDataGeter _draftOrderDataGeter;
        private IDraftOrderSearcher _draftOrderSearcher;
        private IDraftOrderDataDeleter _draftOrderDataDeleter;
        public ProductDeleter(
            IProductDataDeleter productDataDeleter,
            IDraftOrderDataGeter draftOrderDataGeter,
            IDraftOrderSearcher draftOrderSearcher,
            IDraftOrderDataDeleter draftOrderDataDeleter
            )
        {
            _productDataDeleter = productDataDeleter;
            _draftOrderDataGeter = draftOrderDataGeter;
            _draftOrderSearcher = draftOrderSearcher;
            _draftOrderDataDeleter = draftOrderDataDeleter;
        }


        public void DeleteProduct(object id)
        {
            var draftOrders = SearchInDraftOrders(GetDraftOrderData(),null,null,null,(int?)id);
            foreach (var draftOrder in draftOrders)
            {
                DeleteDraftOrderData(draftOrder);
            }
            DeleteProductData(id);
        }

        public void DeleteProduct(ProductsTable product)
        {

            var draftOrders = SearchInDraftOrders(GetDraftOrderData(), null, null, null, product.ProductId);
            foreach (var draftOrder in draftOrders)
            {
                DeleteDraftOrderData(draftOrder);
            }
            DeleteProductData(product);
        }

        public void DeleteDraftOrderData(int darftOrderId)
        {
            _draftOrderDataDeleter.DeleteDraftOrderData(darftOrderId);

        }

        public void DeleteDraftOrderData(DraftOrdersTable draftOrder)
        {
            _draftOrderDataDeleter.DeleteDraftOrderData(draftOrder);
        }


        public void DeleteProductData(object id)
        {
            _productDataDeleter.DeleteProductData(id);
        }

        public void DeleteProductData(ProductsTable product)
        {
            _productDataDeleter.DeleteProductData(product);
        }

        public List<DraftOrdersTable> GetDraftOrderData()
        {
            return _draftOrderDataGeter.GetDraftOrderData();
        }

        public List<DraftOrdersTable> SearchInDraftOrders(IEnumerable<DraftOrdersTable> draftOrders, int? id = null, int? userId = null, string? userName = null, int? prductId = null, string? productName = null, int? brandId = null, string? brandName = null, int? minRequestedCount = null, int? maxRequestedCount = null, long? minAmount = null, long? maxAmount = null, long? minTotalAmount = null, long? maxTotalAmount = null)
        {
            return _draftOrderSearcher.SearchInDraftOrders(draftOrders, id, userId, userName, prductId, productName, brandId, brandName, minRequestedCount, maxRequestedCount, minAmount, maxAmount, minTotalAmount, maxTotalAmount);
        }
    }
}
