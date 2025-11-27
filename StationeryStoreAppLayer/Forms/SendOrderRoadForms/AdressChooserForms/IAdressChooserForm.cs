using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.AdressChooserForms
{
    public interface IAdressChooserForm
    {
        UserTable UserInfo { get; set; }
    }
}
