using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.BrandSearchers
{
    public interface IProductBrandSearcher
    {
        public IEnumerable<ProductsTable> SearchInProductBrands(IEnumerable<ProductsTable> products,int? brandId=null);

    }
}
