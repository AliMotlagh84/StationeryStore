using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Restartors.ComboRestartors
{
    public class ComboRestartor : IComboRestartor
    {
        public void RestartCombo(params ComboBox[] comboBoxes)
        {
            foreach (var comboBox in comboBoxes)
            {
                comboBox.SelectedIndex = 0;
            }
        }
    }
}
