using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Restartors.TextBoxRestartors
{
    public interface ITextBoxRestartor
    {
       void RestartTextBox(params TextBox[] textBoxes);
    }
}
