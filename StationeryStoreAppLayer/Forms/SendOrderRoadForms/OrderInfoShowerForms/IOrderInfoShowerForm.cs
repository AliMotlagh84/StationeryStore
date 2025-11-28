using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.OrderInfoShowerForms
{
    public interface IOrderInfoShowerForm
    {
       UserTable UserInfo { get; set; }
       AdressTable AdressInfo { get; set; }
    }
}
