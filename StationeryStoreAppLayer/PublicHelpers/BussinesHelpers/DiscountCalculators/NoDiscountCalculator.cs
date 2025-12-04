using StationeryStoreUILayer.PublicHelpers.BussinesHelpers.DiscountInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.BussinesHelpers.DiscountCalculators
{
    public class NoDiscountCalculator : IDiscountCalculator 
    {
        public long CalculateDiscount(DiscountInfo discountInfo, string discountName)
        {
            long amount = discountInfo.Amount;
            return amount;
        }
    }
}
