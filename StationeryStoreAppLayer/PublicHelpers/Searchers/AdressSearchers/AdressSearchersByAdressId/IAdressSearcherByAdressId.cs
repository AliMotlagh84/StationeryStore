using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByAdressId
{
    public interface IAdressSearcherByAdressId
    {
        IEnumerable<AdressTable> SearchInAdressesById(IEnumerable<AdressTable> adresses, object? adressId = null);
    }
}
