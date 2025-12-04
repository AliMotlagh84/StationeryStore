using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSerachersByUserName
{
    public interface IUserSearcherByUserName
    {
        IEnumerable<UserTable> SearchInUsersByUserName(IEnumerable<UserTable> users,string? userName);
    }
}
