using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSerachersByUserId
{
    public class UserSearcherByUserId : IUserSearcherByUserId
    {
        public IEnumerable<UserTable> SearchInUsersByUserId(IEnumerable<UserTable> users, int? userId)
        {
            if (userId == null)
                return users;

            return users.Where(u => u.UserId == userId);

        }
    }
}