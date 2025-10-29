using StationeryStore.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataGeters.BrandsDataGeters
{
    public interface IBrandDataGeter
    {
        List<BrandsTable> GetBrandsData();
    }
}
