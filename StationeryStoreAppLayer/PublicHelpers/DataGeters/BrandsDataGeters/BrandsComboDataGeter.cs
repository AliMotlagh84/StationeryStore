using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataGeters.BrandsDataGeters
{
    public class BrandsComboDataGeter : IBrandsComboDataGeter
    {

        public List<BrandsTable> GetBrandsComboData(List<BrandsTable> brandsData)
        {
            List<BrandsTable> _brandsComboData = new List<BrandsTable>();
            _brandsComboData.Add(
                 new BrandsTable()
                 { 
                       BrandId = 0,
                      BrandName = "همه"
                 }
            );
            _brandsComboData.AddRange(brandsData);

            return _brandsComboData;
        }

    }
}
