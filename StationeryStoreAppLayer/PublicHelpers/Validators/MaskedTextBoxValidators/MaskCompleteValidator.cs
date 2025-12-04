using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Validators.MaskedTextBoxValidators
{
    public class MaskCompleteValidator : IMaskCompleteValidator
    {
        public bool IsMaskComplete(MaskedTextBox maskedTextBox)
        {
            if (maskedTextBox.MaskCompleted)
                return true;
            else
                return false;
        }
    }
}
