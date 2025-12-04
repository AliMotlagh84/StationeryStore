using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataBuilders.ProductDataBuilders
{
    public class ProductDataBuilder : IProductDataBuilder
    {
        public ProductsTable BuildProductData(string newProductName, int newBrandId, string newBrandName, long newProductAmount, int newProductCount, DateTime addTime, int? ProductIdForEdit=null)
        {
            var newProduct = new ProductsTable()
            {         
                ProductName = newProductName,
                BrandId = newBrandId,
                BrandName = newBrandName,
                Amount = newProductAmount,
                Count = newProductCount,
                AddTime = addTime
            };
            if (ProductIdForEdit != null) {

                newProduct.ProductId = (int)ProductIdForEdit;
            }
            return newProduct;
        }
    }
}
