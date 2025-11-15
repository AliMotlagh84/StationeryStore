using StationeryStoreAppLayer.Forms.AdderOrEditorForms.BrandAdderOrEditorForm;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ManagerForms.BrandsManagerForm.BrandManagerHelpers.FormOpeners
{
    public class BrandAdderOrEditorFormOpener<TBrandAdderOrEditorForm> : IBrandAdderOrEditorFormOpener where TBrandAdderOrEditorForm:Form,IBrandAdderOrEditorForm
    {
        private TBrandAdderOrEditorForm _brandAdderOrEditorForm;
        public BrandAdderOrEditorFormOpener(TBrandAdderOrEditorForm brandAdderOrEditorForm)
        {
            _brandAdderOrEditorForm = brandAdderOrEditorForm;
        }
        public void OpenBrandAdderOrEditorForm(Form senderForm, BrandsTable brand, bool editMode)
        {
            senderForm.Hide();
            _brandAdderOrEditorForm.BrandInfo = brand;
            _brandAdderOrEditorForm.EditMode = editMode;
            _brandAdderOrEditorForm.ShowDialog();
            senderForm.Show();

        }
    }
}
