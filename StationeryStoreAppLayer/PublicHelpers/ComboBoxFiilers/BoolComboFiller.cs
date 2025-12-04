using StationaryStoreViewModels.OtherViewModles.ComboBoxViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.ComboBoxFiilers
{
    public class BoolComboFiller : IBoolComboFiller
    {
        private List<BoolComboVM> status;
        public void FillBoolCombo(ComboBox comboBox, string allDisplay, string trueDispaly, string falseDispaly)
        {
            status = new List<BoolComboVM>()
           {
            new BoolComboVM(){DisplayMember = allDisplay , ValueMember = null},
            new BoolComboVM(){DisplayMember = trueDispaly , ValueMember = true},
            new BoolComboVM(){DisplayMember = falseDispaly , ValueMember = false},
           };
            comboBox.DataSource = status;
            comboBox.DisplayMember = "DisplayMember";
            comboBox.ValueMember = "ValueMember";
        }
    }
}
