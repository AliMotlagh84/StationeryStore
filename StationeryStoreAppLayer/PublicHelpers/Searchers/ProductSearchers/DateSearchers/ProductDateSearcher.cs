using Microsoft.IdentityModel.Tokens;
using StationaryStoreUtility.Convertores.DateConvertors;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.DateSearchers
{
    public class ProductDateSearcher : IProductDateSearcher
    {
        private IPersianToMiladiDateConvertor _persianToMiladiDateConvertor;
        public ProductDateSearcher(IPersianToMiladiDateConvertor persianToMiladiDateConvertor)
        {
            _persianToMiladiDateConvertor = persianToMiladiDateConvertor;
        }
        public IEnumerable<ProductsTable> SearchInProductAddTimes(IEnumerable<ProductsTable> products, string? minDate = null, string? maxDate = null)
        {
            DateTime _minDate;
            DateTime _maxDate;
            if (((maxDate == null) || (maxDate== "    /  /")) && ((minDate == null) || (minDate == "    /  /")))
            {
                return products;
            }
            if (((maxDate == null) || (maxDate == "    /  /")))
            {
                _minDate = PersianToMiladi(minDate);

                return products.Where(p => _minDate <= p.AddTime);
            }
            else if (((minDate == null) || (minDate == "    /  /")))
            {
                _maxDate = PersianToMiladi(maxDate);
                return products.Where(p => p.AddTime <= _maxDate);

            }
            else
            {
                _minDate = PersianToMiladi(minDate);
                _maxDate = PersianToMiladi(maxDate);
                return products.Where(p => _minDate <= p.AddTime).Where(p => p.AddTime <= _maxDate);

            }


        }

        private DateTime PersianToMiladi(string date)
        {
            return _persianToMiladiDateConvertor.PersianToMiladi(date);
        }
    }
}
