using StationeryStoreUILayer.PublicHelpers.Searchers.BrandsSearcher.BrandIdSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.BrandsSearcher.BrandSearcherByBrandName;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.BrandsSearcher
{
    public class BrandSearcher : IBrandSearcher,
        IBrandSearcherByBrandId,
        IBrandSearcherByBrandName
    {

        private IBrandSearcherByBrandId _brandSearcherByBrandId;
        private IBrandSearcherByBrandName _brandSearcherByBrandName;

        public BrandSearcher(
            IBrandSearcherByBrandName brandSearcherByBrandName,
            IBrandSearcherByBrandId brandSearcherByBrandId
            )
        {
            _brandSearcherByBrandId = brandSearcherByBrandId;
            _brandSearcherByBrandName = brandSearcherByBrandName;
        }

        public IEnumerable<BrandsTable> SearchInBarndsByBrandId(IEnumerable<BrandsTable> brands, int? Id)
        {
           return _brandSearcherByBrandId.SearchInBarndsByBrandId(brands, Id);
        }

        public List<BrandsTable> SearchInBrands(IEnumerable<BrandsTable> brands, int? brandId=null, string? brandName=null)
        {
            var BrandIdFiltered = SearchInBarndsByBrandId(brands,brandId);
            var Filtered = SearchInBrandsByBrandName(BrandIdFiltered,brandName);
            return Filtered.ToList();
        }

        public IEnumerable<BrandsTable> SearchInBrandsByBrandName(IEnumerable<BrandsTable> brands, string? brandName)
        {
           return _brandSearcherByBrandName.SearchInBrandsByBrandName(brands,brandName);
        }
    }
}
