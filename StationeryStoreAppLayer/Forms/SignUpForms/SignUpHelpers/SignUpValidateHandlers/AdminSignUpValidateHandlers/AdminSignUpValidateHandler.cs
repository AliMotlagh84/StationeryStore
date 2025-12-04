using StationaryStoreUtility.Validators.EmailValidator;
using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.AdminiCodeValidator;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.UniqeUserValidators;
using StationeryStoreUILayer.PublicHelpers.Restartors.TextBoxRestartors;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.SignUpValidateHandlers.AdminSignUpValidateHandlers
{
    public class AdminSignUpValidateHandler : IAdminSignUpValidateHandler,
        ITextValidator,
        IEmailValidator,
        IUniqeUserValidator,
        IAdminiCodeValidator
    {

        private ITextValidator _textValidator;
        private IEmailValidator _emailValidator;
        private IUniqeUserValidator _uniqeUserValidator;
        private IAdminiCodeValidator _adminiCodeValidator;

        public AdminSignUpValidateHandler(
        ITextValidator textValidator,
        IEmailValidator emailValidator,
        IUniqeUserValidator uniqeUserValidator,
        IAdminiCodeValidator adminiCodeValidator
            )
        {
            _textValidator = textValidator;
            _emailValidator = emailValidator;
            _adminiCodeValidator = adminiCodeValidator;
            _uniqeUserValidator = uniqeUserValidator;


        }




        public bool ValidateAdminSignUp(string userName, string password, string? email, string adminiCode)
        {
            if (ValidateText(userName) && ValidateText(password) && ValidateText(adminiCode))
            {
                if (!ValidateText(email) || ValidateText(email) && ValidateEmail(email))
                {

                    if (IsUserUniqe(userName, password, email))
                    {
                        if (ValidateAdminiCode(adminiCode))
                        {
                            return true;
                        }
                        else
                        {
                           MessageBox.Show("کد ادمینی اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("این ادمبن از قبل وجود دارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {                   
                    MessageBox.Show("ایمیل نامعتبر است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {               
                MessageBox.Show("نام کاربری , رمز عبور و کد ادمین نباید خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool IsUserUniqe(string username, string password, string email)
        {
          return  _uniqeUserValidator.IsUserUniqe(username, password, email); 
        }
        public bool ValidateAdminiCode(string adminiCode)
        {
            return _adminiCodeValidator.ValidateAdminiCode(adminiCode);
        }

        public bool ValidateEmail(string email)
        {
            return _emailValidator.ValidateEmail(email);
        }

        public bool ValidateText(string text)
        {
            return _textValidator.ValidateText(text);
        }
    }
}
