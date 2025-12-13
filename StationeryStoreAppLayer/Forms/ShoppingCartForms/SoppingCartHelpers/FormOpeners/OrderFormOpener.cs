using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.Forms.OrdersForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.ShoppingCartForms.SoppingCartHelpers.FormOpeners
{
    public class OrderFormOpener<TOrdersForm> : IOrderFormOpener where TOrdersForm :Form,IOrdersForm
    {
        TOrdersForm _ordersForm;

        public OrderFormOpener(TOrdersForm ordersForm)
        {
            _ordersForm = ordersForm;
        }

        public void OpenOrderForm(Form senderForm, UserTable userInfo)
        {
            senderForm.Hide();
            _ordersForm.UserInfo = userInfo;
            _ordersForm.ShowDialog();
            senderForm.Show();
        }
    }
}
