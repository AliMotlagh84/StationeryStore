using StationaryStoreUtility.Validators.EmailValidator;
using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.UniqeUserValidators;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.SignUpValidateHandlers.UserSignUpValidateHandlers
{
    public class UserSignUpValidateHandler : IUserSignUpValidateHandler,
        ITextValidator,
        IEmailValidator,
        IUniqeUserValidator
    {
        private ITextValidator _textValidator;
        private IEmailValidator _emailValidator;
        private IUniqeUserValidator _uniqeUserValidator;
        public UserSignUpValidateHandler(
         ITextValidator textValidator,
         IEmailValidator emailValidator,
         IUniqeUserValidator uniqeUserValidator            
            )
        {
            _textValidator = textValidator;
            _emailValidator = emailValidator;
            _uniqeUserValidator = uniqeUserValidator;
        }


        public bool ValidateUserSignUp(string userName, string password, string? email)
        {
            if (ValidateText(userName) && ValidateText(password))
            {
                if (!ValidateText(email) || ValidateText(email) && ValidateEmail(email))
                {
                    if (IsUserUniqe(userName, password, email))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("این کاربر از قبل وجود دارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("نام کاربری و رمز عبور نباید خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool IsUserUniqe(string username, string password, string email)
        {
           return _uniqeUserValidator.IsUserUniqe(username, password, email);
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
