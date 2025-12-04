using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.TextBoxFillers
{
    public class TextBoxFiller : ITextBoxFiller
    {
        public void FillTextBox(TextBox textBox, string? text)
        {
            textBox.Text = text;    
        }
    }
}
