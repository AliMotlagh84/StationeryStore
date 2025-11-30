using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.LabelSeters
{
    public interface ILabelFillerByText
    {
        void SetLabelText(Label label,string text);
    }
}
