using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ShoppingCartForms.SoppingCartHelpers.FormOpeners
{
    public interface IAdressChooserFormOpener
    {
        void OpenAdressChooserForm(Form senderForm,UserTable userInfo);
    }
}
