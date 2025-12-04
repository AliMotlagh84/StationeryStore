using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByAlley
{
    public class AdressSearcherByAlley : IAdressSearcherByAlley
    {
        public IEnumerable<AdressTable> SearchInAdressesByAlley(IEnumerable<AdressTable> adresses, string? AlleyName = null)
        {
            if (AlleyName == null)
                return adresses;

            return adresses.Where(a => a.Alley.Contains(AlleyName));            
        }
    }
}
