using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers.UserSearchersByEmail
{
    public class UserSearcherByEmail : IUserSearcherByEmail
    {
        public IEnumerable<UserTable> SearchInUserByEmail(IEnumerable<UserTable> users, string? email)
        {
           if(email == null)
                return users;
           
           return users.Where(u => u.Email.Contains(email));
            
        }
    }
}
