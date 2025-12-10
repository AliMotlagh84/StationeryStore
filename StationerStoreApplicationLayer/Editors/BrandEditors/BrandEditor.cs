using StationeryStoreUILayer.PublicHelpers.DataBuilders.BrandDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.DraftOrderDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.DraftOrderDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataEditors.BrandDataEditor;
using StationeryStoreUILayer.PublicHelpers.DataEditors.DraftOrderDataEditors;
using StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreUILayer.PublicHelpers.Editors.ProductEditors;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Editors.BrandEditors
{
    public class BrandEditor : IBrandEditor,
        IBrandDataEditor,
        IProductsDataGeter,
        IProductSearcher,
        IProductDataBuilder,
        IProductEditor,
        IDraftOrderDataGeter,
        IDraftOrderSearcher,
        IDraftOrderDataBuilder,
        IDraftOrderDataEditor


    {
        private IBrandDataEditor _brandDataEditor;
        private IProductsDataGeter _productsDataGeter;
        private IProductSearcher _productSearcher;
        private IProductDataBuilder _productDataBuilder;
        private IProductEditor _productEditor;
        private IDraftOrderDataGeter _draftOrderDataGeter;
        private IDraftOrderSearcher _draftOrderSearcher;
        private IDraftOrderDataBuilder _draftOrderDataBuilder;
        private IDraftOrderDataEditor _draftOrderDataEditor;

        public BrandEditor(
            IBrandDataEditor brandDataEditor,
            IProductsDataGeter productsDataGeter,
            IProductSearcher productSearcher,
            IProductDataBuilder productDataBuilder,
            IProductEditor productEditor,
            IDraftOrderDataGeter draftOrderDataGeter,
            IDraftOrderSearcher draftOrderSearcher,
            IDraftOrderDataBuilder draftOrderDataBuilder,
            IDraftOrderDataEditor draftOrderDataEditor
            )
        {
            _brandDataEditor = brandDataEditor;
            _productsDataGeter = productsDataGeter;
            _productSearcher = productSearcher;
            _productDataBuilder = productDataBuilder;
            _productEditor = productEditor;
            _draftOrderDataGeter = draftOrderDataGeter;
            _draftOrderSearcher = draftOrderSearcher;
            _draftOrderDataBuilder = draftOrderDataBuilder;
            _draftOrderDataEditor = draftOrderDataEditor;
        }



        public DraftOrdersTable BuildDraftOrderData(int userId, string userName, int productId, string productName, int brandId, string brandName, long productAmount, int requestedCount, int? DraftOrderIdForEdit = null)
        {
           return _draftOrderDataBuilder.BuildDraftOrderData(userId,userName,productId,productName,brandId,brandName,productAmount,requestedCount,DraftOrderIdForEdit);
        }

        public ProductsTable BuildProductData(string newProductName, int newBrandId, string newBrandName, long newProductAmount, int newProductCount, DateTime addTime, int? ProductIdForEdit = null)
        {
            return _productDataBuilder.BuildProductData(newProductName,newBrandId,newBrandName,newProductAmount,newProductCount,addTime,ProductIdForEdit);
        }

        public void EditBrand(BrandsTable brand)
        {
            var products = SearchInProducts(GetProductsData(), null, brand.BrandId);
            foreach (var product in products)
            {
                EditProduct(BuildProductData(product.ProductName,brand.BrandId,brand.BrandName,product.Amount,product.Count,product.AddTime,product.ProductId));          
            }

            var draftOrders = SearchInDraftOrders(GetDraftOrderData(), null, null, null, null, null, brand.BrandId, brand.BrandName);
            foreach (var draftOrder in draftOrders)
            {
                EditDraftOrderData(BuildDraftOrderData(draftOrder.UserId, draftOrder.UserName, draftOrder.ProductId, draftOrder.ProductName, brand.BrandId, brand.BrandName, draftOrder.Amount, draftOrder.RequestedCount, draftOrder.DraftOrderId));
            }
            EditBrandData(brand);


        }

        public void EditBrandData(BrandsTable brand)
        {
            _brandDataEditor.EditBrandData(brand);
        }

        public void EditDraftOrderData(DraftOrdersTable draftOrder)
        {
            _draftOrderDataEditor.EditDraftOrderData(draftOrder);
        }

        public void EditProduct(ProductsTable product)
        {
            _productEditor.EditProduct(product);
        }

        public List<DraftOrdersTable> GetDraftOrderData()
        {
            return _draftOrderDataGeter.GetDraftOrderData();
        }

        public List<ProductsTable> GetProductsData()
        {
            return _productsDataGeter.GetProductsData();
        }

        public List<DraftOrdersTable> SearchInDraftOrders(IEnumerable<DraftOrdersTable> draftOrders, int? id = null, int? userId = null, string? userName = null, int? prductId = null, string? productName = null, int? brandId = null, string? brandName = null, int? minRequestedCount = null, int? maxRequestedCount = null, long? minAmount = null, long? maxAmount = null, long? minTotalAmount = null, long? maxTotalAmount = null)
        {
            return _draftOrderSearcher.SearchInDraftOrders(draftOrders, id, userId, userName, prductId, productName, brandId, brandName, minRequestedCount, maxRequestedCount, minAmount, maxAmount, minTotalAmount, maxTotalAmount);
        }

        public List<ProductsTable> SearchInProducts(IEnumerable<ProductsTable> products, string? productName = null, int? brandId = null, bool? availablity = null, long? minAmount = null, long? maxAmount = null, string? minDate = null, string? maxDate = null)
        {
            return _productSearcher.SearchInProducts(products, productName, brandId, availablity, minAmount, maxAmount, minDate, maxDate);
        }
    }
}
