using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdresssSearchersByPostalCode
{
    public interface IAdressSearcherByPostalCode
    {
        public IEnumerable<AdressTable> SerachInAdressesByPostalCode(IEnumerable<AdressTable> adresses, long? PostalCode = null);
    }
}
