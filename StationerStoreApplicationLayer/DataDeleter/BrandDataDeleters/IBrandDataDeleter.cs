using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataDeleter.BrandDataDeleters
{
    public interface IBrandDataDeleter
    {
        void DeleteBrandData(BrandsTable brand);
        void DeleteBrandData(object brandId);
    }
}
