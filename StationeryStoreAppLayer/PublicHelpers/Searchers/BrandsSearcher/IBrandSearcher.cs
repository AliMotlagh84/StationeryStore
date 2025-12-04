using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.BrandsSearcher
{
    public interface IBrandSearcher
    {
        List<BrandsTable> SearchInBrands(IEnumerable<BrandsTable> brands, int? brandId = null,string? brandName = null);
    }
}
