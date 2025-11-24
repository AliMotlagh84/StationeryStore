using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByUserId
{
    public class AdressSearcherByUserId : IAdressSearcherByUserId
    {
        public IEnumerable<AdressTable> SerachInAdressesByUserId(IEnumerable<AdressTable> adresses, object? userId = null)
        {
            if(userId == null || (int?)userId == 0)
                return adresses;

            return adresses.Where(a => a.UserId ==  (int)userId);
        }
    }
}
