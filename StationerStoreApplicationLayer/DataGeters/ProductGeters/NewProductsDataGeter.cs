using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataGeters.ProductGeters
{
    public class NewProductsDataGeter : INewProductsDataGeter
    {
        public List<ProductsTable> GetNewProductsData(int ExpDays)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                return db.ProductsRepository.GetAll(p => ((DateTime.Now.AddDays(-ExpDays))< (p.AddTime)));
            }
        }
    }
}
