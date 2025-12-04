using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using StationeryStoreUILayer.PublicHelpers.BussinesHelpers.DiscountInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.BussinesHelpers.DiscountCalculators
{
    public class FixedDiscountCalculator : IDiscountCalculator
    {
        public long CalculateDiscount(DiscountInfo discountInfo, string discountName)
        {
            long amount = discountInfo.Amount;
            long discount = discountInfo.Get<long>(discountName);
            if (discount < 0 || discount > amount)
                return amount;

            return amount - discount;

        }
    }
}
