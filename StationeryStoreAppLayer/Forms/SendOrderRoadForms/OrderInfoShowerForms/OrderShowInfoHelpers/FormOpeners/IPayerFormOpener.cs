using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.SendOrderRoadForms.OrderInfoShowerForms.OrderShowInfoHelpers.FormOpeners
{
    public interface IPayerFormOpener
    {
        DialogResult OpenPayerForm(Form senderForm, UserTable userInfo,AdressTable adressInfo);
    }
}
