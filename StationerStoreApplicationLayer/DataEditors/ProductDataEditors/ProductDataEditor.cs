using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataEditors.ProductDataEditors
{
    public class ProductDataEditor : IProductDataEditor
    {
        public void EditProductData(ProductsTable newProduct)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.ProductsRepository.Update(newProduct);
                db.Save();
            }
        }
    }
}
