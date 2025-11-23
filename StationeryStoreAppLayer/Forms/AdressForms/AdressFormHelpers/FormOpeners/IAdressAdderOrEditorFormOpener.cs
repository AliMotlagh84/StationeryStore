using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.AdressForms.AdressFormHelpers.FormOpeners
{
    public interface IAdressAdderOrEditorFormOpener
    {
        void OpenAdressAdderOrEditorForm(Form senderForm,UserTable userInfo,bool editMode, AdressTable adressTableForTrueEditMode = null);
    }
}
