using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataDeleter.BrandDataDeleters
{
    public class BrandDataDeleter : IBrandDataDeleter
    {
        public void DeleteBrandData(BrandsTable brand)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.BrandRepository.Delete(brand);
                db.Save();
            }
        }

        public void DeleteBrandData(object brandId)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.BrandRepository.Delete(brandId);
                db.Save();
            }
        }
    }
}
