using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.NumericUdFillers
{
    public class NumericUdFiller : INumericUdFiller
    {
        public void FillNumericUd(NumericUpDown numericUpDown, decimal value)
        {
            numericUpDown.Value = value;
        }
    }
}
