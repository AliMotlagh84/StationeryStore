using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataGeters.BrandsDataGeters
{
    public class BrandsComboDataGeter : IBrandsComboDataGeter
    {
        private List<BrandsTable> _brandsComboData = new List<BrandsTable>();
        private IBrandDataGeter _brandDataGeter;
        public BrandsComboDataGeter(IBrandDataGeter brandDataGeter)
        {
            _brandDataGeter = brandDataGeter;
            _brandsComboData.Add(
                 new BrandsTable()
                 {
                      BrandId = 0,
                      BrandName = "همه"
                 }
                 );
            _brandsComboData.AddRange(_brandDataGeter.GetBrandsData());
        }
        public List<BrandsTable> GetBrandsComboData()
        {
            return _brandsComboData;
        }
    }
}
