using StationeryStoreAppLayer.Forms.AdressForms;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ShoppingCartForms.SoppingCartHelpers.FormOpeners
{
    public class AdressFormOpener<TAdressForm> : IAdressFormOpener where TAdressForm:Form,IAdressForm
    {
        private TAdressForm _adressForm;
        public AdressFormOpener(TAdressForm adressForm)
        {
            _adressForm = adressForm;
        }
        public void OpenAdressForm(Form senderForm, UserTable userInfo)
        {
            senderForm.Hide();
            _adressForm.UserInfo = userInfo;
            _adressForm.ShowDialog();
            senderForm.Show();
        }
    }
}
