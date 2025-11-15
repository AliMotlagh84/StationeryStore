using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataAdders.BrandDataAdders
{
    public class BrandDataAdder : IBrandDataAdder
    {
        public void AddBrandData(BrandsTable brand)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.BrandRepository.Add(brand);
                db.Save();
            }
        }
    }
}
