using StationaryStoreUtility.Validators.textValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.AdressChooserForms.AdressChooserHelpers.AdressChooserFormValidateHandlers
{
    public class AdressChooserFormValidateHandler : IAdressChooserFormValidateHandler,
        ITextValidator
    {
        private ITextValidator _textValidator;
        public AdressChooserFormValidateHandler(ITextValidator textValidator)
        {
            _textValidator = textValidator;
        }
        public bool HandleAdressFormValidate(string txtCity, string txtHouseNumber, string txtPostalNumber)
        {
            if(ValidateText(txtCity)&& ValidateText(txtCity) && ValidateText(txtCity))
            {
                return true;
            }
            else
            {
                MessageBox.Show("یک آدرس را انتخاب کنید","هشدار",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
        }

        public bool ValidateText(string text)
        {
           return _textValidator.ValidateText(text);
        }
    }
}
