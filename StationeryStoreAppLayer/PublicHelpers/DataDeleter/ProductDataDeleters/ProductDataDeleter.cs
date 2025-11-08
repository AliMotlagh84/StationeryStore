using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataDeleter.ProductDataDeleters
{
    public class ProductDataDeleter : IProductDataDeleter
    {
        public void DeleteProductData(object id)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.BrandRepository.Delete(id);
            }
        }

        public void DeleteProductData(ProductsTable product)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.BrandRepository.Delete(product);
            }
        }
    }
}
