using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByStree
{
    public class AdressSearcherByStreet : IAdressSearcherByStreet
    {
        public IEnumerable<AdressTable> SerachInAdressesByStreet(IEnumerable<AdressTable> adresses, string? street = null)
        {
            if(street == null)
                return adresses;

            return adresses.Where(a => a.Street.Contains(street));
        }
    }
}
