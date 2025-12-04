using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers.AdressSearchersByUserName
{
    public interface IAdressSearcherByUserName
    {
        public IEnumerable<AdressTable> SerachInAdressesByUserName(IEnumerable<AdressTable> adresses, string? UserName = null);
    }
}
