using StationaryStoreUtility.Convertores.DateConvertors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.LableSeters
{
    public class TimeLabelSeter : ITimeLabelSeter
    {
        public void SetTime(ToolStripLabel timeLabel, DateTime dateTime)
        {
            timeLabel.Text = dateTime.ToLongTimeString();
        }
    }
}
