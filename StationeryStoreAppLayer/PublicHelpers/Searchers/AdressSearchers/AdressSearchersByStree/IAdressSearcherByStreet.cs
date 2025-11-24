using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByStree
{
    public interface IAdressSearcherByStreet
    {
        public IEnumerable<AdressTable> SerachInAdressesByStreet(IEnumerable<AdressTable> adresses, string? street = null);
    }
}
