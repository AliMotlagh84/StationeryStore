using Microsoft.IdentityModel.Tokens;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers.NameSearchers
{
    public class ProductNameSearcher : IProductNameSearcher
    {
        public IEnumerable<ProductsTable> SearchInProductNames(IEnumerable<ProductsTable> products, string? productName = null)
        {
            if (productName.IsNullOrEmpty())
            {
                return products;
            }
            return products.Where(p => p.ProductName.Contains(productName));

        }
    }
}
