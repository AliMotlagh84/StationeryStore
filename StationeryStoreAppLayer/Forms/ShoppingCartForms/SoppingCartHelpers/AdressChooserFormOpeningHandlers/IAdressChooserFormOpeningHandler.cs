using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.ShoppingCartForms.SoppingCartHelpers.AdressFormChooserOpeningHandlers
{
    public interface IAdressChooserFormOpeningHandler
    {
        void HandleAdressChooserFormOpening(Form HandlerForm,UserTable userInfo);
    }
}
