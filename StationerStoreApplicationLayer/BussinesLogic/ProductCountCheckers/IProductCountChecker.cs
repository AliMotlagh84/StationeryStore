using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.BussinesHelpers.ProductCountCheckers
{
    public interface IProductCountChecker
    {
        bool CheckProductCount(int productCount,int requstedCount);
    }
}
