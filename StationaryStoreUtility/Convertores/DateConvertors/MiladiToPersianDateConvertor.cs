using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryStoreUtility.Convertores.DateConvertors
{
    public class MiladiToPersianDateConvertor : IMiladiToOtherDateConvertor
    {
        PersianCalendar PersianCalendar = new PersianCalendar();
        public string ConvertAsMiladi(DateTime date)
        {
            string persianDate = $"{PersianCalendar.GetYear(date)}/{PersianCalendar.GetMonth(date)}/{PersianCalendar.GetDayOfMonth(date)}";

            return persianDate;
        }
    }
}
