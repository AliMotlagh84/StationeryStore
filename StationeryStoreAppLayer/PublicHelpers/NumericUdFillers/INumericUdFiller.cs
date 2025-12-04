using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.NumericUdFillers
{
    public interface INumericUdFiller
    {
        void FillNumericUd(NumericUpDown numericUpDown,decimal value);
    }
}
