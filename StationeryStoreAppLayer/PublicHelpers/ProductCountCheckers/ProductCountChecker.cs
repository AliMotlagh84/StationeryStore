using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.ProductCountCheckers
{
    public class ProductCountChecker : IProductCountChecker
    {
        public bool CheckProductCount(int productCount, int requstedCount)
        {
            return requstedCount<=productCount;
        }
    }
}
