using StationeryStoreAppLayer.Forms.SendOrderRoadForms.AdressChooserForms;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ShoppingCartForms.SoppingCartHelpers.FormOpeners
{
    public class AdressChooserFormOpener<TAdressChooserForm> : IAdressChooserFormOpener where TAdressChooserForm:Form,IAdressChooserForm
    {
        private TAdressChooserForm _adressChooserForm;

        public AdressChooserFormOpener(TAdressChooserForm adressChooserForm)
        {
            _adressChooserForm = adressChooserForm;
        }
        public void OpenAdressChooserForm(Form senderForm, UserTable userInfo)
        {
            senderForm.Hide();
            _adressChooserForm.UserInfo = userInfo;
            _adressChooserForm.ShowDialog();
            senderForm.Show();

        }
    }
}
