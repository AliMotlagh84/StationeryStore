using StationeryStore.DataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataGeters.ProductGeters
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
