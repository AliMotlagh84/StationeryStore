using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.LableSeters
{
    public interface IDateLabelSeter
    {
        void SetDate(ToolStripLabel dateLabel, DateTime dateTime);
    }
}
