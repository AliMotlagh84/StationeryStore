using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.SendOrderRoadForms.AdressChooserForms.AdressChooserHelpers.FormOpeners
{
    public interface IOrderInfoShowerFormOpener
    {
        DialogResult OpenOrderInfoShowerForm(Form senderForm, UserTable userInfo, AdressTable OrderAdress);
    }
}
