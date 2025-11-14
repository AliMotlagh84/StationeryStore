using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.BrandsSearcher.BrandIdSearchers
{
    public class BrandSearcherByBrandId : IBrandSearcherByBrandId
    {
        public IEnumerable<BrandsTable> SearchInBarndsByBrandId(IEnumerable<BrandsTable> brands, int? Id = null)
        {
            if (Id == null)
            {
                return brands;
            }
            return brands.Where(b => b.BrandId == b.BrandId);           
        }
    }
}
