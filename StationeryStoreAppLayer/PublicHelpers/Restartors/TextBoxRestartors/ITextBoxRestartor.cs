using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Restartors.TextBoxRestartors
{
    public interface ITextBoxRestartor
    {
       void RestartTextBox(params TextBox[] textBoxes);
    }
}
