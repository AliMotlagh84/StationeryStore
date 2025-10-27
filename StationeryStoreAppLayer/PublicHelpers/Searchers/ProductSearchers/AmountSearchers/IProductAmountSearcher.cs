using StationeryStore.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.AmountSearchers
{
    public interface IProductAmountSearcher 
    {
        public IEnumerable<ProductsTable> SearchInProductAmounts(IEnumerable<ProductsTable> products, long? minAmount = null,long? maxAmount =null);

    }
}
