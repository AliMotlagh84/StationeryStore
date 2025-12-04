using Microsoft.EntityFrameworkCore;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataGeters.ProductGeters
{
    public class SingleProductDataGeter : ISingleProductDataGeter
    {
        public ProductsTable GetSigleProduct(object Id)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
              return  db.ProductsRepository.GetById(Id);
            }
        }
    }
}
