using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.ShoppingCartForms.SoppingCartHelpers.FormOpeners
{
    public interface IOrderFormOpener
    {
        void OpenOrderForm(Form senderForm,UserTable userInfo);
    }
}
