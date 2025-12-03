using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.PayerFormValidateHandlers
{
    public interface IPayerFormValidateHandler
    {
        bool CanUserPay(MaskedTextBox cardNumber,MaskedTextBox cVV2,MaskedTextBox txtCaptcha, int password,string userCaptchaCode,string captchaCode);
    }
}
