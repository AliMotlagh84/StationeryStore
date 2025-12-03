using StationeryStoreAppLayer.PublicHelpers.BussinesHelpers.DiscountInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.BussinesHelpers.DiscountCalculators
{
    public class PercentageDiscountCalculator : IDiscountCalculator
    {
        public long CalculateDiscount(DiscountInfo discountInfo, string discountName)
        {
            long amount = discountInfo.Amount;
            double discountsPrecent = discountInfo.Get<double>(discountName);
            if (discountsPrecent > 100 || discountsPrecent < 0)
                return amount;


            return (long)Math.Round(amount * (1 - discountsPrecent));
        }

    }
}
