using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataDeleter.ProductDataDeleters
{
    public class ProductDataDeleter : IProductDataDeleter
    {
        public void DeleteProductData(object id)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.ProductsRepository.Delete(id);
                db.Save();
            }
        }

        public void DeleteProductData(ProductsTable product)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.ProductsRepository.Delete(product);
                db.Save();
            }
        }
    }
}
