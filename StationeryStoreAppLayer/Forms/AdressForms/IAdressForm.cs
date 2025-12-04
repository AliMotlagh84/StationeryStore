using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.AdressForms
{
    public interface IAdressForm
    {
        UserTable UserInfo { get; set; }
    }
}
