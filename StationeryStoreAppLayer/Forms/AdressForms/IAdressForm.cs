using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.AdressForms
{
    public interface IAdressForm
    {
        UserTable UserInfo { get; set; }
    }
}
