using StationeryStoreAppLayer.PublicHelpers.Searchers.BrandsSearcher;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.UserSearchers.UserSearchersByPassword
{
    public interface IUserSearcherByPassword
    {
        IEnumerable<UserTable>  SearchInUserByPassword(IEnumerable<UserTable> users,string? password);
    }
}
