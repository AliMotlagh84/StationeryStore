using StationeryStoreAppLayer.Forms.ManagerForms.BrandsManagerForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ManagerForms.StoreManagerForms.StoreMangerHelpers.FormOpeners
{
    public class BrandsManagerFormOpener<TBrandsManagerForm> : IBrandsManagerFormOpener where TBrandsManagerForm : Form, IBrandManagerForm
    {
        private TBrandsManagerForm _TBrandsManagerForm;
        public BrandsManagerFormOpener(TBrandsManagerForm tBrandsManagerForm)
        {
            _TBrandsManagerForm = tBrandsManagerForm;
        }
        public void OpneBrandsManagerForm(Form senderForm)
        {
            senderForm.Hide();
            _TBrandsManagerForm.ShowDialog();
            senderForm.Show();
        }
    }
}
