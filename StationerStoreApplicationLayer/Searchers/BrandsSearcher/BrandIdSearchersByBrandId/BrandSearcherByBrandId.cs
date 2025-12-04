using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.BrandsSearcher.BrandIdSearchers
{
    public class BrandSearcherByBrandId : IBrandSearcherByBrandId
    {
        public IEnumerable<BrandsTable> SearchInBarndsByBrandId(IEnumerable<BrandsTable> brands, int? Id = null)
        {
            if (Id == null || Id == 0)
            {
                return brands;
            }
            return brands.Where(b => b.BrandId == b.BrandId);
        }
    }
}
