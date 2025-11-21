using StationeryStoreAppLayer.Forms.CountManagerForms.DraftOrderRequestedCountEditor;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ShoppingCartForms.SoppingCartHelpers.FormOpeners
{
    public class DraftOrderRequestedCountEditorFormOpener<TDraftOrderRequestedCountForm> : IDraftOrderRequestedCountEditorFormOpener where TDraftOrderRequestedCountForm:Form,IDraftOrderRequestedCountEditor
    {
        private TDraftOrderRequestedCountForm _draftOrderRequestedCountForm;
        public DraftOrderRequestedCountEditorFormOpener(TDraftOrderRequestedCountForm draftOrderRequestedCountForm)
        {
          _draftOrderRequestedCountForm = draftOrderRequestedCountForm;  
        }
        public void OpenDraftOrderRequestedCountEditor(DraftOrdersTable draftOrderInfo)
        {
            _draftOrderRequestedCountForm.DraftOrderInfo = draftOrderInfo;
            _draftOrderRequestedCountForm.ShowDialog();
        }
    }
}
