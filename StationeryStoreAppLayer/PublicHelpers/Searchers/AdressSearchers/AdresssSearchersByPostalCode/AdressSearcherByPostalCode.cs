using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdresssSearchersByPostalCode
{
    public class AdressSearcherByPostalCode : IAdressSearcherByPostalCode
    {
        public IEnumerable<AdressTable> SerachInAdressesByPostalCode(IEnumerable<AdressTable> adresses, long? PostalCode = null)
        {
            if(PostalCode == null || PostalCode == 1000000000)
                return adresses;

            return adresses.Where(a => a.PostalCode == PostalCode);
        }
    }
}
