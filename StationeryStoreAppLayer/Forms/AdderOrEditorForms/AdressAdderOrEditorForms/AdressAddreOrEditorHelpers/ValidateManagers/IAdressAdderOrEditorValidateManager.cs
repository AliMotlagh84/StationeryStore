using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.AdderOrEditorForms.AdressAdderOrEditorForms.AdressAddreOrEditorHelpers.ValidateManagers
{
    public interface IAdressAdderOrEditorValidateManager
    {
        bool ManageValidate(string cityName,string streetName,string alleyName,string houseNumber);
    }
}
