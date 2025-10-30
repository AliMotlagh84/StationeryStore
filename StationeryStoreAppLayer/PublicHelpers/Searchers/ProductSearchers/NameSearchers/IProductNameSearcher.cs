using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.NameSearchers
{
    public interface IProductNameSearcher
    {
        public IEnumerable<ProductsTable> SearchInProductNames(IEnumerable<ProductsTable> products,string? productName = null);

    }
}
