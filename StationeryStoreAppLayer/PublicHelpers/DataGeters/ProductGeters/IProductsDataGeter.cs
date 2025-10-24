using StationeryStore.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataGeters.ProductGeters
{
    public interface IProductsDataGeter
    {
        List<ProductsTable> GetProductsData(); 
    }
}
