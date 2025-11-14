using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.BrandsSearcher.BrandSearcherByBrandName
{
    public interface IBrandSearcherByBrandName
    {
        IEnumerable<BrandsTable> SearchInBrandsByBrandName(IEnumerable<BrandsTable> brands, string? brandName = null);
    }
}
