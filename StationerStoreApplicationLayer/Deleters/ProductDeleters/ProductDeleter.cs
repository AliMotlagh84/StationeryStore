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
using StationerStoreApplicationLayer.Deleters.DraftOrderDeleters;

namespace StationerStoreApplicationLayer.Deleters.ProductDeleters
{
    public class ProductDeleter : IProductDeleter,
        IProductDataDeleter,
        IDraftOrderDataGeter,
        IDraftOrderSearcher,
        IDraftOrderDeleter
    {

        private IProductDataDeleter _productDataDeleter;
        private IDraftOrderDataGeter _draftOrderDataGeter;
        private IDraftOrderSearcher _draftOrderSearcher;
        private IDraftOrderDeleter _draftOrderDeleter;
        public ProductDeleter(
            IProductDataDeleter productDataDeleter,
            IDraftOrderDataGeter draftOrderDataGeter,
            IDraftOrderSearcher draftOrderSearcher,
            IDraftOrderDeleter draftOrderDeleter
            )
        {
            _productDataDeleter = productDataDeleter;
            _draftOrderDataGeter = draftOrderDataGeter;
            _draftOrderSearcher = draftOrderSearcher;
            _draftOrderDeleter = draftOrderDeleter;
        }


        public void DeleteProduct(object id)
        {
            var draftOrders = SearchInDraftOrders(GetDraftOrderData(),null,null,null,(int?)id);
            foreach (var draftOrder in draftOrders)
            {
                DeleteDrfatOrder(draftOrder);
            }
            DeleteProductData(id);
        }

        public void DeleteProduct(ProductsTable product)
        {

            var draftOrders = SearchInDraftOrders(GetDraftOrderData(), null, null, null, product.ProductId);
            foreach (var draftOrder in draftOrders)
            {
                DeleteDrfatOrder(draftOrder);
            }
            DeleteProductData(product);
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

        public void DeleteDrfatOrder(DraftOrdersTable draftOrder)
        {
            _draftOrderDeleter.DeleteDrfatOrder(draftOrder);
        }

        public void DeleteDrfatOrder(object draftOrderId)
        {
            _draftOrderDeleter.DeleteDrfatOrder(draftOrderId);
        }
    }
}
