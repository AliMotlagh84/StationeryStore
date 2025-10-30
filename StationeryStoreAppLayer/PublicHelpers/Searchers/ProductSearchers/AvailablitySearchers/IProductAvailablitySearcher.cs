using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.AvailablitySearchers
{
    public interface IProductAvailablitySearcher
    {
        public IEnumerable<ProductsTable> SearchInProductAvailablities(IEnumerable<ProductsTable> products,bool? availablity=null);

    }
}
