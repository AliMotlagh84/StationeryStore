using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.LableSeters
{
    public class IntroducingLabelSeter : IIntroducingLabelSeter
    {
        public void SetIntrducingLabel(Label introducingLabel, string text)
        {
            introducingLabel.Text = text;
        }
    }
}
