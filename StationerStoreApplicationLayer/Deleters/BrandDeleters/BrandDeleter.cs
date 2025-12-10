using StationeryStoreUILayer.PublicHelpers.DataDeleter.BrandDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.DraftOrderDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StationerStoreApplicationLayer.Deleters.ProductDeleters;

namespace StationerStoreApplicationLayer.Deleters.BrandDeleters
{
    public class BrandDeleter : IBrandDeleter,
        IBrandDataDeleter,
        IProductsDataGeter,
        IProductSearcher,
        IProductDeleter,
        IDraftOrderDataGeter,
        IDraftOrderSearcher,
        IDraftOrderDataDeleter


    {
        private IBrandDataDeleter _brandDataDeleter;
        private IProductsDataGeter _productsDataGeter;
        private IProductSearcher _productSearcher;
        private IProductDeleter _productDeleter;
        private IDraftOrderDataGeter _draftOrderDataGeter;
        private IDraftOrderSearcher _draftOrderSearcher;
        private IDraftOrderDataDeleter _draftOrderDataDeleter;
        public BrandDeleter(
            IBrandDataDeleter brandDataDeleter,
            IProductsDataGeter productsDataGeter,
            IProductSearcher productSearcher,
            IProductDeleter productDeleter,
            IDraftOrderDataGeter draftOrderDataGeter,
            IDraftOrderSearcher draftOrderSearcher,
            IDraftOrderDataDeleter draftOrderDataDeleter
            )
        {
            _brandDataDeleter = brandDataDeleter;
            _productsDataGeter = productsDataGeter;
            _productSearcher = productSearcher;
            _productDeleter = productDeleter;
            _draftOrderDataGeter = draftOrderDataGeter;
            _draftOrderSearcher = draftOrderSearcher;
            _draftOrderDataDeleter = draftOrderDataDeleter;
        }
        public void DeleteBrand(BrandsTable brand)
        {
            var products = SearchInProducts(GetProductsData(), null, brand.BrandId);
            foreach (var product in products)
            {
                DeleteProduct(product);
            }
            var draftOrders = SearchInDraftOrders(GetDraftOrderData(),null,null,null,null,null,brand.BrandId,brand.BrandName);
            foreach (var draftOrder in draftOrders)
            {
                DeleteDraftOrderData(draftOrder);
            }
            DeleteBrandData(brand);
        }

        public void DeleteBrand(object brandId)
        {
            var products = SearchInProducts(GetProductsData(), null, (int)brandId);
            foreach (var product in products)
            {
                DeleteProduct(product);
            }
            var draftOrders = SearchInDraftOrders(GetDraftOrderData(), null, null, null, null, null, (int)brandId);
            foreach (var draftOrder in draftOrders)
            {
                DeleteDraftOrderData(draftOrder);
            }
            DeleteBrandData(brandId);
        }

        public void DeleteBrandData(BrandsTable brand)
        {
            _brandDataDeleter.DeleteBrandData(brand);
        }

        public void DeleteBrandData(object brandId)
        {
            _brandDataDeleter.DeleteBrandData(brandId);

        }

        public void DeleteDraftOrderData(int darftOrderId)
        {
            _draftOrderDataDeleter.DeleteDraftOrderData(darftOrderId);
        }

        public void DeleteDraftOrderData(DraftOrdersTable draftOrder)
        {
            _draftOrderDataDeleter.DeleteDraftOrderData(draftOrder);
        }

        public void DeleteProduct(object id)
        {
            _productDeleter.DeleteProduct(id);
        }

        public void DeleteProduct(ProductsTable product)
        {
            _productDeleter.DeleteProduct(product);

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
