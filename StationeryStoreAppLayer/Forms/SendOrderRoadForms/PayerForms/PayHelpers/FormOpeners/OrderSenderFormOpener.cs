using StationeryStoreAppLayer.Forms.SendOrderRoadForms.OrderSenderForms;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.FormOpeners
{
    public class OrderSenderFormOpener<TOrderSenderForm> : IOrderSenderFormOpener where TOrderSenderForm:Form,IOrderSenderForm
    {
        private TOrderSenderForm _orderSenderForm;

        public OrderSenderFormOpener(TOrderSenderForm orderSenderForm)
        {
            _orderSenderForm = orderSenderForm;
        }

        public void OpenPayerFormSender(Form senderForm, UserTable userInfo, long orderTotalAmount)
        {
            senderForm.Hide();
            _orderSenderForm.UserInfo = userInfo;
            _orderSenderForm.OrderTotalAmount = orderTotalAmount;
            _orderSenderForm.ShowDialog();
            senderForm.DialogResult = DialogResult.OK;
        }
    }
}
