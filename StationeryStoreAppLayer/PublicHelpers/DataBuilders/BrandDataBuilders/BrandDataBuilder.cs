using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataBuilders.BrandDataBuilders
{
    public class BrandDataBuilder : IBrandDataBuilder
    {
        public BrandsTable BuildBrandData(string brandName, int? brandIdForEdit = null)
        {
            var brandData = new BrandsTable()
            {
                BrandName = brandName,
            };
            if (brandIdForEdit != null)
            {
                brandData.BrandId = (int)brandIdForEdit;
            }
            return brandData;
        }
    }
}
