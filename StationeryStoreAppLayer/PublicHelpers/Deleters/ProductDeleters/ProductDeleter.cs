using StationeryStoreAppLayer.PublicHelpers.DataDeleter.ProductDataDeleters;
using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Deleters.ProductDeleters
{
    public class ProductDeleter : IProductDeleter,IProductDataDeleter
    {

        private IProductDataDeleter _productDataDeleter;
        public ProductDeleter(IProductDataDeleter productDataDeleter    )
        {
            _productDataDeleter = productDataDeleter;
        }




        public void DeleteProduct(object id)
        {
            using(EfUnitOfWork db = new EfUnitOfWork())
            {
                db.BrandRepository.Delete(id);
            }
        }

        public void DeleteProduct(ProductsTable product)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.BrandRepository.Delete(product);
            }
        }

        public void DeleteProductData(object id)
        {
            _productDataDeleter.DeleteProductData(id);
        }

        public void DeleteProductData(ProductsTable product)
        {
            _productDataDeleter.DeleteProductData(product);
        }
    }
}
