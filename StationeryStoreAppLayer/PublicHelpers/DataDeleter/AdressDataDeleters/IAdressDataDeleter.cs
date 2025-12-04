using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataDeleter.AdressDataDeleters
{
    public interface IAdressDataDeleter
    {
        void DeleteAdressData(object id);
        void DeleteAdressData(AdressTable adress);
    }
}
