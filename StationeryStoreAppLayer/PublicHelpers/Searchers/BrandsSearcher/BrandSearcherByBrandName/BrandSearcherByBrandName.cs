using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.BrandsSearcher.BrandSearcherByBrandName
{
    public class BrandSearcherByBrandName : IBrandSearcherByBrandName
    {
        public IEnumerable<BrandsTable> SearchInBrandsByBrandName(IEnumerable<BrandsTable> brands, string? brandName = null)
        {
            if (brandName == null)
            {
                return brands;
            }
            return brands.Where(b => b.BrandName.Contains(brandName));
        }
    }
}
