using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Deleters.ProductDeleters
{
    public interface IProductDeleter
    {
        void DeleteProduct(object id);
        void DeleteProduct(ProductsTable product);
    }
}
