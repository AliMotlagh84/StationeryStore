using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByUserId
{
    public interface IAdressSearcherByUserId
    {
        public IEnumerable<AdressTable> SerachInAdressesByUserId(IEnumerable<AdressTable> adresses, object? userId = null);
    }
}
