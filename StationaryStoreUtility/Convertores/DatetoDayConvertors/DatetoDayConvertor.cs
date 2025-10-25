using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryStoreUtility.Convertores.DatetoDayConvertors
{
    public class DatetoDayConvertor : IDateToDayConvertor
    {
        public int DatetoDay(DateTime date)
        {
            var dateDuration = date.Subtract(DateTime.MinValue);
            return (int)(dateDuration.TotalDays);
        }
    }
}
