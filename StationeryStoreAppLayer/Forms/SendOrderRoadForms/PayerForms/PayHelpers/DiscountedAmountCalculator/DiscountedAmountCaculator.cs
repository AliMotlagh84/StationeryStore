 using StationeryStoreUILayer.PublicHelpers.BussinesHelpers.DiscountCalculators;
using StationeryStoreUILayer.PublicHelpers.BussinesHelpers.DiscountInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.DiscountedAmountCalculator
{
    public class DiscountedAmountCaculator : IDiscountedAmountCaculator

    {
        public long CalculateDiscountedAmount<T>(long amount, string discountName, T discountValue, IDiscountCalculator discountCalculator) where T : INumber<T>
        {
            DiscountInfo discountInfo = new DiscountInfo();
            discountInfo.Amount = amount;
            discountInfo.Set(discountName, discountValue);   
            return discountCalculator.CalculateDiscount(discountInfo, discountName);
        }
    }
}
