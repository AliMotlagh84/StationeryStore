using StationeryStoreAppLayer.Forms.SendOrderRoadForms.OrderInfoShowerForms;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.AdressChooserForms.AdressChooserHelpers.FormOpeners
{
    public class OrderInfoShowerFormOpener<TOrderInfoShowerForm> : IOrderInfoShowerFormOpener where TOrderInfoShowerForm:Form,IOrderInfoShowerForm
    {
        TOrderInfoShowerForm _orderInfoShowerForm;

        public OrderInfoShowerFormOpener(TOrderInfoShowerForm orderInfoShowerForm)
        {
            _orderInfoShowerForm = orderInfoShowerForm;
        }
        public DialogResult OpenOrderInfoShowerForm(Form senderForm, UserTable userInfo, AdressTable OrderAdress)
        {
            senderForm.Hide();
            _orderInfoShowerForm.UserInfo = userInfo;
            _orderInfoShowerForm.AdressInfo = OrderAdress;
            return _orderInfoShowerForm.ShowDialog();
        }
    }
}
