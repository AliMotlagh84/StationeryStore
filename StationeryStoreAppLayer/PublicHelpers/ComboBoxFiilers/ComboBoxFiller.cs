using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.ComboBoxFiilers
{
    public class ComboBoxFiller : IComboBoxFiller
    {
        public void FillCombo(ComboBox comboBox, object data, string displayMember, string ValueMember)
        {
            comboBox.DataSource = data;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = ValueMember;
        }

    }
}
