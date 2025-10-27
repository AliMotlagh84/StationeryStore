using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryStoreUtility.Convertores.DateConvertors
{
    public class PersianToMiladiDateConvertor : IPersianToMiladiDateConvertor
    {
        PersianCalendar persianCalendar = new PersianCalendar();
        public DateTime PersianToMiladi(string date)
        {
            try
            {
                string[] splitDate = date.Split("/");
                int year = int.Parse(splitDate[0]);
                int month = int.Parse(splitDate[1]);
                int day = int.Parse(splitDate[2]);
                return persianCalendar.ToDateTime(year, month, day, 0, 0, 0, 0);
            }
            catch
            {
                return DateTime.Now;
            }


            
        }
    }
}
