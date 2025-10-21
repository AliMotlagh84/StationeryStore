using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryStoreUtility.Convertores.DateConvertors
{
    public interface IMiladiToOtherDateConvertor
    {
        string ConvertAsMiladi(DateTime date);
    }
}
