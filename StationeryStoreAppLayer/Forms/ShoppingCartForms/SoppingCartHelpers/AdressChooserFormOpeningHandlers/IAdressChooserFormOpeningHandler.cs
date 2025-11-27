using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ShoppingCartForms.SoppingCartHelpers.AdressFormChooserOpeningHandlers
{
    public interface IAdressChooserFormOpeningHandler
    {
        void HandleAdressChooserFormOpening(Form HandlerForm,UserTable userInfo);
    }
}
