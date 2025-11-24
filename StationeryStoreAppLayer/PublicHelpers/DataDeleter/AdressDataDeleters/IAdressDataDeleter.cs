using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataDeleter.AdressDataDeleters
{
    public interface IAdressDataDeleter
    {
        void DeleteAdressData(object id);
        void DeleteAdressData(AdressTable adress);
    }
}
