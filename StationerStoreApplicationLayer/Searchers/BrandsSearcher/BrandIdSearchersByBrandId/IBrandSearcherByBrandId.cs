using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.BrandsSearcher.BrandIdSearchers
{
    public interface IBrandSearcherByBrandId
    {
        IEnumerable<BrandsTable> SearchInBarndsByBrandId(IEnumerable<BrandsTable> brands, int? Id = null);
    }
}
