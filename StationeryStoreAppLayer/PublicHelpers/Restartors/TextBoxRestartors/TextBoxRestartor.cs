using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Restartors.TextBoxRestartors
{
    public class TextBoxRestartor : ITextBoxRestartor
    {
        public void RestartTextBox(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Text = null;    
            }
        }
    }
}
