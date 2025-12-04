using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.SendOrderRoadForms.AdressChooserForms
{
    public interface IAdressChooserForm
    {
        UserTable UserInfo { get; set; }
    }
}
