using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataDeleter.ProductDataDeleters
{
    public interface IProductDataDeleter
    {
        void DeleteProductData(object id);
        void DeleteProductData(ProductsTable product);
    }
}
