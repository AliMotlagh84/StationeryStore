using StationeryStoreUILayer.PublicHelpers.Searchers.BrandsSearcher;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSearchersByPassword
{
    public interface IUserSearcherByPassword
    {
        IEnumerable<UserTable>  SearchInUserByPassword(IEnumerable<UserTable> users,string? password);
    }
}
