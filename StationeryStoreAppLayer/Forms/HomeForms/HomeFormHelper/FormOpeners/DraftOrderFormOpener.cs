using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.Forms.DraftOrderForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.FormOpeners
{
    public class DraftOrderFormOpener<TDraftOrderForm> : IDraftOrderFormOpener where TDraftOrderForm : Form, IDraftOrderForm
    {
        private TDraftOrderForm draftOrderForm;
        public DraftOrderFormOpener(TDraftOrderForm draftOrderForm)
        {
            this.draftOrderForm = draftOrderForm;
        }
        public void OpenDraftOrderForm(ProductsTable productInfo, UserTable OrdererInfo)
        {
       
            draftOrderForm.Orderer  = OrdererInfo;
            draftOrderForm.SelectedProduct = productInfo;
            draftOrderForm?.ShowDialog();
        }
    }
}
