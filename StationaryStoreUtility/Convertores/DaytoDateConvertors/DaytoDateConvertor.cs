using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryStoreUtility.Convertores.DaytoDateConvertors
{
    public class DaytoDateConvertor : IDayToDateConvertor
    {
        public DateTime DaytoDate(int days)
        {
           return DateTime.MinValue.AddDays(days);
        }
    }
}
