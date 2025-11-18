using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.UserSearchers.UserSearchersByAdminiSatate
{
    public class UserSearcherByAdminiState : IUserSearcherByAdminiState
    {
        public IEnumerable<UserTable> SearchInUsersByAdminiState(IEnumerable<UserTable> users, bool? adminiState)
        {
           if(adminiState ==null)
                return users;

           return users.Where(u => u.IsAdmin ==  adminiState);
        }
    }
}
