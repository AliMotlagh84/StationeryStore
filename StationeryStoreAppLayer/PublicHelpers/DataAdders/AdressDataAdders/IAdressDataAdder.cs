using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataAdders.AdressDataAdders
{
    public interface IAdressDataAdder
    {
        void AddAdressData(AdressTable adress);
    }
}
