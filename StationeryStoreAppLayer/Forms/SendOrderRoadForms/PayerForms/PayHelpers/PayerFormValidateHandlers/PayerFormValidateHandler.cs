using StationaryStoreUtility.Validators.DebitCardPasswordValidators;
using StationeryStoreAppLayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.CaptchaValidators;
using StationeryStoreAppLayer.PublicHelpers.Validators.MaskedTextBoxValidators;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.PayerFormValidateHandlers
{
    public class PayerFormValidateHandler : IPayerFormValidateHandler,
        IMaskCompleteValidator,
        IDebitCardPasswordLenghtValidator,
        ICaptchaValidator
    {

        private IMaskCompleteValidator _maskCompleteValidator;
        private IDebitCardPasswordLenghtValidator _debitCardPasswordLenghtValidator;
        private ICaptchaValidator _captchaValidator;

        public PayerFormValidateHandler(IMaskCompleteValidator maskCompleteValidator,
            IDebitCardPasswordLenghtValidator debitCardPasswordLenghtValidator,
            ICaptchaValidator captchaValidator)
        {
            _maskCompleteValidator = maskCompleteValidator;
            _debitCardPasswordLenghtValidator = debitCardPasswordLenghtValidator;
            _captchaValidator = captchaValidator;
        }

        public bool CanUserPay(MaskedTextBox cardNumber, MaskedTextBox cVV2, MaskedTextBox txtCaptcha, int password, string userCaptchaCode, string captchaCode)
        {
            if (!(IsMaskComplete(cardNumber) && IsMaskComplete(cVV2)))
            {
                MessageBox.Show("اطلاعات کارت را تکمیل کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!IsMaskComplete(txtCaptcha))
            {
                MessageBox.Show("کد تصویر را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!ValidateCaptcha(captchaCode,userCaptchaCode))
            {
                MessageBox.Show("کد امنیتی اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!IsDebitCardPasswordLenghtValid(password))
            {
                MessageBox.Show("تعداد ارقام رمز معتبر نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("پرداخت با موفقیت انجام شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        public bool IsDebitCardPasswordLenghtValid(int password)
        {
            return _debitCardPasswordLenghtValidator.IsDebitCardPasswordLenghtValid(password);
        }

        public bool IsMaskComplete(MaskedTextBox maskedTextBox)
        {
            return _maskCompleteValidator.IsMaskComplete(maskedTextBox);
        }

        public bool ValidateCaptcha(string captchaCode, string userAnswer)
        {
            return _captchaValidator.ValidateCaptcha(captchaCode, userAnswer);
        }
    }
}
