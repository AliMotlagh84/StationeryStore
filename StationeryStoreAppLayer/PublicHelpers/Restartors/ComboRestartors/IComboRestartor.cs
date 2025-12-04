using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Restartors.ComboRestartors
{
    public interface IComboRestartor
    {
        void RestartCombo(params ComboBox[] comboBoxes);
    }
}
