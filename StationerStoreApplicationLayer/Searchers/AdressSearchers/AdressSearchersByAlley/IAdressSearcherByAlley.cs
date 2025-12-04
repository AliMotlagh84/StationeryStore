using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByAlley
{
    public interface IAdressSearcherByAlley
    {
        IEnumerable<AdressTable> SearchInAdressesByAlley(IEnumerable<AdressTable> adresses,string? AlleyName = null);
    }
}
