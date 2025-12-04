using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.FormTextSeters
{
    public class FormTextSeter : IFormTextSeter
    {
        public void SetFormText(Form form, string text)
        {
            form.Text = text;
        }
    }
}
