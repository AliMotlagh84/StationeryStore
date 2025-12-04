using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.TextBoxFillers
{
    public interface ITextBoxFiller
    {
        void FillTextBox(TextBox textBox,string? text);
    }
}
