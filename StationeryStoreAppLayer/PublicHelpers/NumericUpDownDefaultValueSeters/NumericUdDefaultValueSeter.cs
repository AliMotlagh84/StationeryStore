using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StationeryStoreUILayer.PublicHelpers.NumericUpDownDefaultValueSeters
{
    public class NumericUdDefaultValueSeter : INumericUdDefaultValueSeter
    {
        public void SetNumericUdDefaultValue(long defaultValue, params NumericUpDown[] numericUdCollection)
        {
            NumericUpDown[] numericUpDowns = numericUdCollection;
            foreach (NumericUpDown numericUpDown in numericUpDowns)
            {
                numericUpDown.Validating += delegate (object sender, CancelEventArgs e)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)sender;

                    if (string.IsNullOrWhiteSpace(numericUpDown.Text))
                    {
                        numericUpDown.Value = defaultValue;
                    }
                };
            };

        }
        void SetDefalutValue(object sender, CancelEventArgs e)
        {

        }
    }
}
