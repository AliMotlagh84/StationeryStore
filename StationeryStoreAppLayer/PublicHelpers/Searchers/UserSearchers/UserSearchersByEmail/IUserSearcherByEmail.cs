using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSearchersByEmail
{
    public interface IUserSearcherByEmail
    {
        IEnumerable<UserTable> SearchInUserByEmail(IEnumerable<UserTable> users, string? email);

    }
}
