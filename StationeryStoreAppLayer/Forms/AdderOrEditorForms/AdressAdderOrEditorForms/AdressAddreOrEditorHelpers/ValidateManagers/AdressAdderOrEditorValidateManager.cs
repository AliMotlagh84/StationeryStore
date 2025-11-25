using StationaryStoreUtility.Validators.textValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.AdderOrEditorForms.AdressAdderOrEditorForms.AdressAddreOrEditorHelpers.ValidateManagers
{
    public class AdressAdderOrEditorValidateManager : IAdressAdderOrEditorValidateManager,ITextValidator
    {
        private ITextValidator _textValidator;
        public AdressAdderOrEditorValidateManager(ITextValidator textValidator)
        {
            _textValidator = textValidator;
        }
        public bool ManageValidate(string cityName, string streetName, string alleyName, string houseNumber)
        {
            if(ValidateText(cityName) && ValidateText(streetName) && ValidateText(alleyName) && ValidateText(houseNumber))
            {
                return true;
            }
            else
            {
                MessageBox.Show("شهر, خیابان , کوچه و پلاک نباید خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ValidateText(string text)
        {
            return _textValidator.ValidateText(text);
        }
    }
}
