using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.AdressForms.AdressFormHelpers.FormOpeners
{
    public interface IAdressAdderOrEditorFormOpener
    {
        void OpenAdressAdderOrEditorForm(Form senderForm,UserTable userInfo,bool editMode, AdressTable adressTableForTrueEditMode = null);
    }
}
