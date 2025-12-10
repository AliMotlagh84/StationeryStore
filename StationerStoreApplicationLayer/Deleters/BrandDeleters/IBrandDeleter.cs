using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Deleters.BrandDeleters
{
    public interface IBrandDeleter
    {
        void DeleteBrand(BrandsTable brand);
        void DeleteBrand(object brandId);
    }
}
