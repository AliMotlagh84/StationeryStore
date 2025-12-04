using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.SendOrderRoadForms.AdressChooserForms.AdressChooserHelpers.AdressChooserFormValidateHandlers
{
    public interface IAdressChooserFormValidateHandler
    {
        bool HandleAdressFormValidate(string txtCity,string txtHouseNumber,string txtPostalNumber);
    }
}
