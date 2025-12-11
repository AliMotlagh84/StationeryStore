using StationeryStoreUILayer.Forms.ManagerForms.OrderManagerForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.ManagerForms.StoreManagerForms.StoreMangerHelpers.FormOpeners
{
    public class OrdersManagerFormOpener<TOrdersManagerForm> : IOrdersManagerFormOpener where TOrdersManagerForm:Form,IOrderManagerForm
    {
        private TOrdersManagerForm _ordersManagerForm;

        public OrdersManagerFormOpener(TOrdersManagerForm ordersManagerForm)
        {
            _ordersManagerForm = ordersManagerForm;
        }

        public void OpenOrdersManagerForm(Form senderForm)
        {
            senderForm.Hide();
            _ordersManagerForm.ShowDialog();
            senderForm.Show();
        }
    }
}
