using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.ComboBoxFiilers
{
    public interface IBoolComboFiller
    {
        void FillBoolCombo(ComboBox comboBox,string allDisplay,string trueDispaly,string falseDispaly);
    }
}
