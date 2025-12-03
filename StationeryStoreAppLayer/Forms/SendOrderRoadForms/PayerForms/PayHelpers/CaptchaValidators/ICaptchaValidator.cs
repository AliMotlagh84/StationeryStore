using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.CaptchaValidators
{
    public interface ICaptchaValidator
    {
        public bool ValidateCaptcha(string captchaCode, string userAnswer);
    }
}
