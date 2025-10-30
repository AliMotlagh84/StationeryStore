using StationeryStoreDataLayer.Models;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.AmountSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.AvailablitySearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.BrandSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.DateSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.NameSearchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers
{
    public class ProductSearcher : IProductSearcher , IProductNameSearcher, IProductBrandSearcher, IProductDateSearcher, IProductAmountSearcher, IProductAvailablitySearcher
    {
        private IEnumerable<ProductsTable> products { get; set; }
        private IProductNameSearcher _productNameSearcher;
        private IProductBrandSearcher _productBrandSearcher;
        private IProductAmountSearcher _productAmountSearcher;
        private IProductDateSearcher _productDateSearcher;
        private IProductAvailablitySearcher _productAvailablitySearcher;
        public ProductSearcher(
            IProductNameSearcher productNameSearcher,
            IProductBrandSearcher productBrandSearcher,
            IProductAmountSearcher productAmountSearcher,
            IProductDateSearcher productDateSearcher,
            IProductAvailablitySearcher productAvailablitySearcher
            )
        {
            _productNameSearcher = productNameSearcher;
            _productBrandSearcher = productBrandSearcher;
            _productAmountSearcher = productAmountSearcher;
            _productDateSearcher = productDateSearcher;
            _productAvailablitySearcher = productAvailablitySearcher;

        }

        public List<ProductsTable> SearchInProducts(IEnumerable<ProductsTable> products, string? productName = null, int? brandId = null,bool? availablity = null, long? minAmount = null, long? maxAmount = null, string? minDate = null, string? maxDate = null)
        {
            this.products = products;
            var nameFiltered = SearchInProductNames(products, productName);
            var brandFiltered = SearchInProductBrands(nameFiltered, brandId);
            var amountFiltered = SearchInProductAmounts(brandFiltered,minAmount,maxAmount);
            var dateFiltered = SearchInProductAddTimes(amountFiltered,minDate,maxDate);
            var filtered = SearchInProductAvailablities(dateFiltered,availablity);

            return filtered.ToList();

        }

        public IEnumerable<ProductsTable> SearchInProductAmounts(IEnumerable<ProductsTable> products, long? minAmount = null, long? maxAmount = null)
        {
            return _productAmountSearcher.SearchInProductAmounts(products,minAmount,maxAmount);
        }

        public IEnumerable<ProductsTable> SearchInProductAvailablities(IEnumerable<ProductsTable> products, bool? availablity = null)
        {
            return _productAvailablitySearcher.SearchInProductAvailablities(products, availablity);
        }

        public IEnumerable<ProductsTable> SearchInProductBrands(IEnumerable<ProductsTable> products, int? brandId = null)
        {
            return _productBrandSearcher.SearchInProductBrands(products,brandId);
        }

        public IEnumerable<ProductsTable> SearchInProductNames(IEnumerable<ProductsTable> products, string? productName = null)
        {
            return _productNameSearcher.SearchInProductNames(products,productName);
        }

        public IEnumerable<ProductsTable> SearchInProductAddTimes(IEnumerable<ProductsTable> products, string? minDate = null, string? maxDate = null)
        {
            return _productDateSearcher.SearchInProductAddTimes(products,minDate,maxDate);

        }

    }
}
