using StationeryStoreUILayer.PublicHelpers.BussinesHelpers.DiscountCalculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.DiscountedAmountCalculator
{
    public interface IDiscountedAmountCaculator
    {
        long CalculateDiscountedAmount<T>(long amount,string discountName,T discountValue,IDiscountCalculator discountCalculator) where T:INumber<T>;
    }
}
