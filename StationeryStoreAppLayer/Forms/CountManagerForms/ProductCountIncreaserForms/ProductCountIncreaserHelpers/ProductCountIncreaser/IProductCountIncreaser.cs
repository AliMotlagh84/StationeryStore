using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.CountManagerForms.ProductCountIncreaserForms.ProductCountIncreaserHelpers.ProductCountIncreaser
{
    public interface IProductCountIncreaser
    {
        ProductsTable IncreaseProductCount(ProductsTable product, int IncreaseCount);
    }
}
