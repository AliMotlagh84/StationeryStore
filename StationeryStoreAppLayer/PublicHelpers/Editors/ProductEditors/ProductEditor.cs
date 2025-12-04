using StationeryStoreUILayer.PublicHelpers.DataBuilders.DraftOrderDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataEditors.DraftOrderDataEditors;
using StationeryStoreUILayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Editors.ProductEditors
{
    public class ProductEditor :
        IProductEditor,
        IProductDataEditor,
        IDraftOrderDataGeter,
        IDraftOrderSearcher,
        IDraftOrderDataBuilder,
        IDraftOrderDataEditor

    {
        private IProductDataEditor _productDataEditor;
        private IDraftOrderDataGeter _draftOrderDataGeter;
        private IDraftOrderSearcher _draftOrderSearcher;
        private IDraftOrderDataBuilder _draftOrderDataBuilder;
        private IDraftOrderDataEditor _draftOrderDataEditor;


        public ProductEditor
            (
            IProductDataEditor productDataEditor,
            IDraftOrderDataGeter draftOrderDataGeter,
            IDraftOrderSearcher draftOrderSearcher,
            IDraftOrderDataBuilder draftOrderDataBuilder,
            IDraftOrderDataEditor draftOrderDataEditor
            )
        {
            _productDataEditor = productDataEditor;
            _draftOrderDataGeter = draftOrderDataGeter;
            _draftOrderSearcher = draftOrderSearcher;
            _draftOrderDataBuilder = draftOrderDataBuilder;
            _draftOrderDataEditor = draftOrderDataEditor;
        }

        public DraftOrdersTable BuildDraftOrderData(int userId, string userName, int productId, string productName, int brandId, string brandName, long productAmount, int requestedCount, int? DraftOrderIdForEdit = null)
        {
            return _draftOrderDataBuilder.BuildDraftOrderData(userId, userName, productId, productName, brandId, brandName, productAmount, requestedCount, DraftOrderIdForEdit);
        }

        public void EditDraftOrderData(DraftOrdersTable draftOrder)
        {
            _draftOrderDataEditor.EditDraftOrderData(draftOrder);
        }

        public void EditProduct(ProductsTable product)
        {
            var draftOrders = SearchInDraftOrders(GetDraftOrderData(), null, null, null, product.ProductId);
            foreach (var draftOrder in draftOrders)
            {
                EditDraftOrderData(BuildDraftOrderData(draftOrder.UserId,draftOrder.UserName,product.ProductId,product.ProductName,product.BrandId,product.BrandName,product.Amount,draftOrder.RequestedCount,draftOrder.DraftOrderId));
            }
            EditProductData(product);
        }

        public void EditProductData(ProductsTable newProduct)
        {
            _productDataEditor.EditProductData(newProduct);
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
