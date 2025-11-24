using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByUserName
{
    public interface IAdressSearcherByUserName
    {
        public IEnumerable<AdressTable> SerachInAdressesByUserName(IEnumerable<AdressTable> adresses, string? UserName = null);
    }
}
