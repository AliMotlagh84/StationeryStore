using StationeryStoreUILayer.Forms.ManagerForms.DraftOrdersManagerForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.ManagerForms.StoreManagerForms.StoreMangerHelpers.FormOpeners
{
    public class DraftOrdersManagerFormOpener<TDraftOrdersManagerForm> : IDraftOrdersManagerFormOpener where TDraftOrdersManagerForm:Form,IDraftOrdersManagerForm
    {
        private TDraftOrdersManagerForm _draftOrdersManagerForm;

        public DraftOrdersManagerFormOpener(TDraftOrdersManagerForm draftOrdersManagerForm)
        {
            _draftOrdersManagerForm = draftOrdersManagerForm;
        }

        public void OpenDraftOrdersManagerForm(Form senderForm)
        {
            senderForm.Hide();
            _draftOrdersManagerForm.ShowDialog();
            senderForm.Show();
        }
    }
}
