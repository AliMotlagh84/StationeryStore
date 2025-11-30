using StationeryStoreAppLayer.Forms.SendOrderRoadForms.PayerForms;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.OrderInfoShowerForms.OrderShowInfoHelpers.FormOpeners
{
    public class PayerFormOpener<TPayerForm> : IPayerFormOpener where TPayerForm:Form,IPayerForm
    {
        private TPayerForm _payerFrom;
        public PayerFormOpener(TPayerForm payerForm)
        {
            _payerFrom = payerForm;
        }
        public DialogResult OpenPayerForm(Form senderForm,UserTable userInfo, AdressTable adressInfo)
        {
            senderForm.Hide();
            _payerFrom.UserInfo = userInfo;
            _payerFrom.AdressInfo = adressInfo;      
            return _payerFrom.ShowDialog();
            
        }
    }
}
