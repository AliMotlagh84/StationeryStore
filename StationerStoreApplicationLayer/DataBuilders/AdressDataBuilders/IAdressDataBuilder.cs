using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataBuilders.AdressDataBuilders
{
    public interface IAdressDataBuilder
    {
        AdressTable BuildAdressData(int userId,string userName,string city,string street,string alley,string houseNumber,long postalCode,int? adressIdForEdit = null);
    }
}
