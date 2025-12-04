using StationeryStoreUILayer.Forms.AdderOrEditorForms.AdressAdderOrEditorForms;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.AdressForms.AdressFormHelpers.FormOpeners
{
    public class AdressAdderOrEditorFormOpener<TAdressAdderOrEditorForm> : IAdressAdderOrEditorFormOpener where TAdressAdderOrEditorForm:Form,IAdressAdderOrEditorForm
    {
        private TAdressAdderOrEditorForm _adressAdderOrEditorForm;
        public AdressAdderOrEditorFormOpener(TAdressAdderOrEditorForm adressAdderOrEditorForm)
        {
            _adressAdderOrEditorForm = adressAdderOrEditorForm;
        }
        public void OpenAdressAdderOrEditorForm(Form senderForm, UserTable userInfo, bool editMode,AdressTable adressTableForTrueEditMode = null)
        {
            senderForm.Hide();
            _adressAdderOrEditorForm.UserInfo = userInfo;
            _adressAdderOrEditorForm.AdressInfo = adressTableForTrueEditMode;
            _adressAdderOrEditorForm.EditMode = editMode;
            _adressAdderOrEditorForm.ShowDialog();
            senderForm.Show();
        }
    }
}
