using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByHouseNumber
{
    public interface IAdressSearcherByHouseNumber
    {
        IEnumerable<AdressTable> SerachInAdressesByHouseNumber(IEnumerable<AdressTable> adresses, string? houseNumber = null);
    }
}
