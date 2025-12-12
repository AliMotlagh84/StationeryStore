using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.ProductCountCheckers
{
    public interface IProductCountChecker
    {
        bool CheckProductCount(int productCount,int requstedCount);
    }
}
