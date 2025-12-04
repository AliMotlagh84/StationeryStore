using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.ComboBoxValueSelectors
{
    public class ComboBoxValueSelector : IComboBoxValueSelector
    {
        public void SelectComboBoxValue(ComboBox comboBox, object? value)
        {
            comboBox.SelectedValue = value;
        }
    }
}
