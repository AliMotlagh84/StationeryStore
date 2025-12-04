using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByAdressId
{
    public interface IAdressSearcherByAdressId
    {
        IEnumerable<AdressTable> SearchInAdressesById(IEnumerable<AdressTable> adresses, object? adressId = null);
    }
}
