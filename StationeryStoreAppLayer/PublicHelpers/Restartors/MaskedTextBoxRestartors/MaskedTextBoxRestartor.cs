using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Restartors.MaskedTextBoxRestartors
{
    public class MaskedTextBoxRestartor : IMaskedTextBoxRestartor
    {
        public void RestartMaskedTextBox(params MaskedTextBox[] maskedTextBoxes)
        {
            foreach (var maskedTextBox in maskedTextBoxes)
            {
                maskedTextBox.ResetText();
            }
        }
    }
}
