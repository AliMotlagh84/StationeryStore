using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByUserName
{
    public class AdressSearcherByUserName : IAdressSearcherByUserName
    {
        public IEnumerable<AdressTable> SerachInAdressesByUserName(IEnumerable<AdressTable> adresses, string? UserName = null)
        {
            if (UserName == null)
                return adresses;

            return adresses.Where(a => a.UserName.Contains(UserName));
        }
    }
}
