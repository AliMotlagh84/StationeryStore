using StationaryStoreUtility.Convertores.DateConvertors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.LableSeters
{
    public class DateLabelSeter : IDateLabelSeter
    {
        private IMiladiToOtherDateConvertor _dateConvertor;
        public DateLabelSeter(IMiladiToOtherDateConvertor dateConvertor)
        {
            _dateConvertor = dateConvertor;
        }

        public void SetDate(ToolStripLabel dateLabel, DateTime dateTime)
        {
            dateLabel.Text = _dateConvertor.ConvertAsMiladi(dateTime);
        }
    }
}
