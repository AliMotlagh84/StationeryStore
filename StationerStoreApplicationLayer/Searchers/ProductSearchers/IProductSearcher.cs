using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.AmountSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.AvailablitySearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.BrandSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.DateSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.NameSearchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers
{
    public interface IProductSearcher
    {
        List<ProductsTable> SearchInProducts(IEnumerable<ProductsTable> products, string? productName = null, int? brandId = null, bool? availablity = null, long? minAmount = null, long? maxAmount = null, string? minDate = null, string? maxDate = null);
    }
}
