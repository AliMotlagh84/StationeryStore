using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByUserName
{
    public class AdressSearcherByUserName : IAdressSearcherByUserName
    {
        public IEnumerable<AdressTable> SerachInAdressesByUserName(IEnumerable<AdressTable> adresses, string? UserName = null)
        {
            if (adresses == null)
                return adresses;

            return adresses.Where(a => a.UserName.Contains(UserName));
        }
    }
}
