using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataDeleter.BrandDataDeleter
{
    public interface IBrandDataDeleter
    {
        void DeleteBrandData(BrandsTable brand);
        void DeleteBrandData(object brandId);
    }
}
