using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataAdders.ProductDataAdders
{
    public class ProductDataAdder : IProductDataAdder
    {
        public void AddProductData(ProductsTable newPruduct)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.ProductsRepository.Add(newPruduct);
                db.Save();
            }
        }
    }
}
