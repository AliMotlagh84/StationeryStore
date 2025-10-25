using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryStoreUtility.Convertores.DaytoDateConvertors
{
    public interface IDayToDateConvertor
    {
        DateTime DaytoDate(int days);
    }
}
