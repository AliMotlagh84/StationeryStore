using StationeryStore.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers.AmountSearchers
{
    public class ProductAmountSearcher : IProductAmountSearcher
    {
        public IEnumerable<ProductsTable> SearchInProductAmounts(IEnumerable<ProductsTable> products, long? minAmount = null, long? maxAmount = null)
        {
            if (((maxAmount == 0) || (maxAmount == null)) && ((minAmount == 0) || (minAmount == null)))
            {
                return products;
            }
            else if ((maxAmount == 0) || (maxAmount == null))
            {
                return products.Where(p => minAmount <= p.Amount);
            }
            else if ((minAmount == 0) || (minAmount == null))
            {
                return products.Where(p => p.Amount <= maxAmount);
            }
            else
            {
                return products.Where(p => minAmount <= p.Amount).Where(p => p.Amount <= maxAmount);
            }
        }


        }
    }

