using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataGeters.BrandsDataGeters
{
    public class BrandDataGeter : IBrandDataGeter
    {
        public List<BrandsTable> GetBrandsData()
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                return db.BrandRepository.GetAll();
            }
        }
    }
}
