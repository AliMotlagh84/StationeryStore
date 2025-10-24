using StationeryStore.DataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataGeters.ProductGeters
{
    public class ProductsDataGeter : IProductsDataGeter
    {
        public List<ProductsTable> GetProductsData()
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                return db.ProductsRepository.GetAll();
            }
        }
    }
}
