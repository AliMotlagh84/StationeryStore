using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByHouseNumber
{
    public class AdressSearcherByHouseNumber : IAdressSearcherByHouseNumber
    {
        public IEnumerable<AdressTable> SerachInAdressesByHouseNumber(IEnumerable<AdressTable> adresses, string? houseNumber = null)
        {
            if (houseNumber == null)
                return adresses;

            return adresses.Where(a=>a.HouseNumber.Contains(houseNumber));

        }
    }
}
