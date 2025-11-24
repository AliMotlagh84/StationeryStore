using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByAlley
{
    public interface IAdressSearcherByAlley
    {
        IEnumerable<AdressTable> SearchInAdressesByAlley(IEnumerable<AdressTable> adresses,string? AlleyName = null);
    }
}
