using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByCity
{
    public interface IAdressSearcherByCity
    {
        public IEnumerable<AdressTable> SearchInAdressesByCity(IEnumerable<AdressTable> adresses, string? City = null);
    }
}
