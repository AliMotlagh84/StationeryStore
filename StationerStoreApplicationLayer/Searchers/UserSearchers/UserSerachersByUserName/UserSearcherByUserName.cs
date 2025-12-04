using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSerachersByUserName
{
    public class UserSearcherByUserName : IUserSearcherByUserName
    {
        public IEnumerable<UserTable> SearchInUsersByUserName(IEnumerable<UserTable> users, string? userName)
        {
            if(userName == null)
                return users;


            return users.Where(u => u.UserName.Contains(userName));
        }
    }
}
