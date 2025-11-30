using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Validators.MaskedTextBoxValidators
{
    public interface IMaskCompleteValidator
    {
        bool IsMaskComplete(MaskedTextBox maskedTextBox);
    }
}
