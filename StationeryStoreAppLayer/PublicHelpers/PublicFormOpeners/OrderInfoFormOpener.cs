using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.Forms.OrderInfoForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.FormOpeners
{
    public class OrderInfoFormOpener<TOrderInfoForm> : IOrderInfoFormOpener where TOrderInfoForm : Form,IOrderInfoForm
    {
        private TOrderInfoForm _orderInfoForm;

        public OrderInfoFormOpener(TOrderInfoForm orderInfoForm)
        {
            _orderInfoForm = orderInfoForm;
        }

        public void OpenOrderInfoForm(Form senderForm, OrdersTable order)
        {
            senderForm.Hide();
            _orderInfoForm.Order = order;
            _orderInfoForm.ShowDialog();
            senderForm.Show();
        }
    }
}
