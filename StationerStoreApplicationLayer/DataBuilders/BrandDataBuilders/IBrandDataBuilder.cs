using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataBuilders.BrandDataBuilders
{
    public interface IBrandDataBuilder
    {
        BrandsTable BuildBrandData(string brandName, int? BrandIdForEdit = null);

    }
}
