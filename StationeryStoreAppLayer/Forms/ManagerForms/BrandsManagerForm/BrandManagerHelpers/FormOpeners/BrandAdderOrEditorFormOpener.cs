using StationeryStoreUILayer.Forms.AdderOrEditorForms.BrandAdderOrEditorForm;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.ManagerForms.BrandsManagerForm.BrandManagerHelpers.FormOpeners
{
    public class BrandAdderOrEditorFormOpener<TBrandAdderOrEditorForm> : IBrandAdderOrEditorFormOpener where TBrandAdderOrEditorForm:Form,IBrandAdderOrEditorForm
    {
        private TBrandAdderOrEditorForm _brandAdderOrEditorForm;
        public BrandAdderOrEditorFormOpener(TBrandAdderOrEditorForm brandAdderOrEditorForm)
        {
            _brandAdderOrEditorForm = brandAdderOrEditorForm;
        }
        public void OpenBrandAdderOrEditorForm(Form senderForm, bool editMode, BrandsTable brandInfoForTrueEditMode = null)
        {
            senderForm.Hide();
            _brandAdderOrEditorForm.BrandInfo = brandInfoForTrueEditMode;
            _brandAdderOrEditorForm.EditMode = editMode;
            _brandAdderOrEditorForm.ShowDialog();
            senderForm.Show();

        }
    }
}
