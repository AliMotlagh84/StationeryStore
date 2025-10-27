using StationeryStore.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.AvailablitySearchers
{
    public class ProductAvailablitySearcher : IProductAvailablitySearcher
    {
        public IEnumerable<ProductsTable> SearchInProductAvailablities(IEnumerable<ProductsTable> products, int? minCount=null)
        {
            if ((minCount == null)|| (minCount == 0))
            {
                return products;
            }
            return products.Where(p => p.Count >= minCount);
        }
    }
}
