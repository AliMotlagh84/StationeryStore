using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ShoppingCartForms.SoppingCartHelpers.FormOpeners
{
    public interface IAdressFormOpener
    {
        void OpenAdressForm(Form senderForm,UserTable userInfo);
    }
}
