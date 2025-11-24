using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByAdressId
{
    public class AdressSearcherByAdressId : IAdressSearcherByAdressId
    {
        public IEnumerable<AdressTable> SearchInAdressesById(IEnumerable<AdressTable> adresses, object? adressId = null)
        {
            if (adressId == null || (int?)adressId == 0)
                return adresses;

            return adresses.Where(a => a.AdressId == (int)adressId);
        }
    }
}
