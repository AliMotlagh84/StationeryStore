using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.LabelSeters
{
    public class LabelFillerByText : ILabelFillerByText
    {
        public void SetLabelText(Label label, string text)
        {
            label.Text = text;  
        }
    }
}
