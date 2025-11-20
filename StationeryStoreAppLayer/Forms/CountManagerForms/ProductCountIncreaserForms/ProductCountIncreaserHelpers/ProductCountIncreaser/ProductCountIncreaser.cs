using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.CountManagerForms.ProductCountIncreaserForms.ProductCountIncreaserHelpers.ProductCountIncreaser
{
    public class ProductCountIncreaser : IProductCountIncreaser
    {
        public ProductsTable IncreaseProductCount(ProductsTable product, int IncreaseCount)
        {
            product.Count += IncreaseCount; 
            return product;
        }
    }
}
