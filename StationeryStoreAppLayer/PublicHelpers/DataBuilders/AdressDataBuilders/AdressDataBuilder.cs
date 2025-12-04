using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataBuilders.AdressDataBuilders
{
    public class AdressDataBuilder : IAdressDataBuilder
    {
        public AdressTable BuildAdressData(int userId, string userName, string city, string street, string alley, string houseNumber, long postalCode, int? adressIdForEdit = null)
        {
            AdressTable adress = new AdressTable()
            {
                UserId = userId,
                UserName = userName,
                City = city,
                Street = street,
                Alley = alley,
                HouseNumber = houseNumber,
                PostalCode = postalCode,
            };
            if (adressIdForEdit != null)
            {
                adress.AdressId = (int)adressIdForEdit;
            }
            return adress;

        }
    }
}
