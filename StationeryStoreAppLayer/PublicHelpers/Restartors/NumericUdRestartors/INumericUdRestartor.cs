using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Restartors.INumericUdRestartor
{
    public interface INumericUdRestartor
    {
        void RestartNumericUd(params NumericUpDown[] numericUpDowns );
    }
}
