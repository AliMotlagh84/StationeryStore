using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.BussinesHelpers.DiscountInfos
{
    public class DiscountInfo
    {
        private long amount;
        Dictionary<string, object> discounts = new Dictionary<string, object>();
        public long Amount
        {
            get => amount;
            set
            {
                if (0 < value) { amount = value; }
            }
        }
       
        public void Set(string discountName, object discountValue)
        {
            discounts.Add(discountName, discountValue);
        }

        public T Get<T>(string discountName)
        {
            return  (T)discounts[discountName];
        }

    }
}
