using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByAlley
{
    public class AdressSearcherByAlley : IAdressSearcherByAlley
    {
        public IEnumerable<AdressTable> SearchInAdressesByAlley(IEnumerable<AdressTable> adresses, string? AlleyName = null)
        {
            if (adresses == null)
                return adresses;

            return adresses.Where(a => a.Alley.Contains(AlleyName));            
        }
    }
}
