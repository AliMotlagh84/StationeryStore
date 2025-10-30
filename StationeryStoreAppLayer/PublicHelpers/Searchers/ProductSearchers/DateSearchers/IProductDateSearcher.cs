using Microsoft.EntityFrameworkCore.Diagnostics;
using StationaryStoreUtility.Convertores.DateConvertors;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.DateSearchers
{
    public interface IProductDateSearcher
    {
        public IEnumerable<ProductsTable> SearchInProductAddTimes(IEnumerable<ProductsTable> products,string? minDate = null,string? maxDate = null);

    }
}
