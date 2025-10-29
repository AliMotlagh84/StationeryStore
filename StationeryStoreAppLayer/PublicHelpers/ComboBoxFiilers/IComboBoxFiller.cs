using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.ComboBoxFiilers
{
    public interface IComboBoxFiller
    {
        void FillCombo(ComboBox comboBox,object data,string displayMember, string ValueMember);
    }
}
