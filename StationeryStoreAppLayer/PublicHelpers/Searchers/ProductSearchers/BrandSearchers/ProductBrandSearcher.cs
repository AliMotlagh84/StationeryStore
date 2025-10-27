using StationeryStore.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.BrandSearchers
{
    public class ProductBrandSearcher : IProductBrandSearcher
    {
        public IEnumerable<ProductsTable> SearchInProductBrands(IEnumerable<ProductsTable> products, int? brandId = null)
        {
            if ((brandId == null)||(brandId == 0))
            {
                return products;
            }
            return products.Where(p => p.BrandId == brandId);
        }
    }
}
