using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.CaptchaValidators
{
    public class CaptchaValidator : ICaptchaValidator
    {
        public bool ValidateCaptcha(Random captchaRnd, string userAnswer)
        {
            string captchaCode = captchaRnd.Next(10000, 99999).ToString();
            if (captchaCode == userAnswer)
            {
                return true;
            }
            else
            {
                MessageBox.Show("کد امنیتی غلط است");
                return false;
            }
        }
    }
}
