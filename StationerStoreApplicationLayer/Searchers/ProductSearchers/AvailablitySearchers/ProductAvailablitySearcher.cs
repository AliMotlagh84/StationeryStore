using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.AvailablitySearchers
{
    public class ProductAvailablitySearcher : IProductAvailablitySearcher
    {
        public IEnumerable<ProductsTable> SearchInProductAvailablities(IEnumerable<ProductsTable> products, bool? availablity)
        {
            if ((availablity == null))
            {
                return products;
            }
            else if (availablity == true)
            {
                return products.Where(p => p.Count > 0);
            }
            else
            {
                return products.Where(p => p.Count <= 0);
            }
        }
    }
}

