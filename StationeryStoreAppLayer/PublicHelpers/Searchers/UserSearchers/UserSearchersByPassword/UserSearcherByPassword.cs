using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSearchersByPassword
{
    public class UserSearcherByPassword : IUserSearcherByPassword
    {
        public IEnumerable<UserTable> SearchInUserByPassword(IEnumerable<UserTable> users, string? password)
        {
            if(password == null)
                return users;

            return users.Where(u => u.Password==password);
        }
    }
}
