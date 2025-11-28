using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.AdressChooserForms.AdressChooserHelpers.FormOpeners
{
    public interface IOrderInfoShowerFormOpener
    {
        DialogResult OpenOrderInfoShowerForm(Form senderForm, UserTable userInfo, AdressTable OrderAdress);
    }
}
