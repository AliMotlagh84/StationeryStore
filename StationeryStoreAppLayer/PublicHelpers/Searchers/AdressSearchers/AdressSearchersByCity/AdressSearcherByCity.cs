using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByCity
{
    public class AdressSearcherByCity : IAdressSearcherByCity
    {
        public IEnumerable<AdressTable> SearchInAdressesByCity(IEnumerable<AdressTable> adresses, string? City = null)
        {
            if(City == null) 
                return  adresses;

            return adresses.Where(a => a.City.Contains(City));
        }
    }
}
