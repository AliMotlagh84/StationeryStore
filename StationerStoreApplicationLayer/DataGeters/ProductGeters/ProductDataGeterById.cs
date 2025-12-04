using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataGeters.ProductGeters
{
    public class ProductDataGeterById : IProductDataGeterById
    {
        public ProductsTable GetProductDataById(object ProductId)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                return db.ProductsRepository.GetById(ProductId);
            }
        }
    }
}
