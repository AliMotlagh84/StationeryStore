using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataGeters.BrandsDataGeters
{
    public interface IBrandsComboDataGeter
    {
        List<BrandsTable> GetBrandsComboData(List<BrandsTable> brandsData);
    }
}
