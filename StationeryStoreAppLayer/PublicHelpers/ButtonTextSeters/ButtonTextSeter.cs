using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.ButtonTextSeters
{
    public class ButtonTextSeter : IButtonTextSeter
    {
        public void SetButtonText(Button button, string text)
        {
            button.Text = text;
        }
    }
}
