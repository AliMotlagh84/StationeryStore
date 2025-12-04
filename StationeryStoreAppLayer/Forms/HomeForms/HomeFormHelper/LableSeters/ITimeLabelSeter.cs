using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.LableSeters
{
    public interface ITimeLabelSeter
    {
        void SetTime(ToolStripLabel timeLabel, DateTime dateTime);
    }
}
