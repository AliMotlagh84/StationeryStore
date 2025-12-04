using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSerachersByUserId
{
    public interface IUserSearcherByUserId
    {
        IEnumerable<UserTable> SearchInUsersByUserId(IEnumerable<UserTable> users, int? userId);
    }
}
