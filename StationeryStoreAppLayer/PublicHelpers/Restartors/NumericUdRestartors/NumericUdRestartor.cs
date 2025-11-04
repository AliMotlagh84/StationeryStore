using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Restartors.INumericUdRestartor
{
    public class NumericUdRestartor : INumericUdRestartor
    {
        public void RestartNumericUd(params NumericUpDown[] numericUpDowns)
        {
            foreach (var numericUpDown in numericUpDowns)
            {

                numericUpDown.Value = 0;
                numericUpDown.ResetText();
            }
        }
    }
}
