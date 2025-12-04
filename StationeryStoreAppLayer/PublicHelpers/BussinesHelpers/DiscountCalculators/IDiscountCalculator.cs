using StationeryStoreUILayer.PublicHelpers.BussinesHelpers.DiscountInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.BussinesHelpers.DiscountCalculators
{
    public interface IDiscountCalculator
    {
        long CalculateDiscount(DiscountInfo discountInfo,string discountName);
    }
}
