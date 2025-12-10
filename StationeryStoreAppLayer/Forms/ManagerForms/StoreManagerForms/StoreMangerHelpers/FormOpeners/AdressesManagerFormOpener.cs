using StationeryStoreUILayer.Forms.ManagerForms.AdressesManagerForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.ManagerForms.StoreManagerForms.StoreMangerHelpers.FormOpeners
{
    public class AdressesManagerFormOpener<TAdressesManagerForm> : IAdressesManagerFormOpener where TAdressesManagerForm: Form,IAdressesManagerForm
    {
        TAdressesManagerForm _adressesManagerForm;

        public AdressesManagerFormOpener(TAdressesManagerForm adressesManagerForm)
        {
            _adressesManagerForm = adressesManagerForm;
        }

        public void OpenAdressesManagerForm(Form senderForm)
        {
            senderForm.Hide();
            _adressesManagerForm.ShowDialog();
            senderForm.Show();
        }
    }
}
