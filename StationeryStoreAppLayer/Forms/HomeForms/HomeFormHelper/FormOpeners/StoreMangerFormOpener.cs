using StationeryStoreAppLayer.Forms.ManagerForms.StoreManagerForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.FormOpeners
{
    public class StoreMangerFormOpener<TStoreManagerForm> : IStoreManagerFormOpener where TStoreManagerForm : Form,IStoreManagerForm
    {
        private TStoreManagerForm _storeManagerForm;
        public StoreMangerFormOpener(TStoreManagerForm storeManagerForm)
        {
            _storeManagerForm = storeManagerForm;
        }
        public void OpenStoreManagerForm(Form senderForm)
        {
            senderForm.Hide();
            _storeManagerForm.ShowDialog();
            senderForm.Show();
        }
    }
}
