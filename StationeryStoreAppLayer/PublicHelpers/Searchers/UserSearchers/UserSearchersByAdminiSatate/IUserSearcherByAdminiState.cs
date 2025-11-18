using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Searchers.UserSearchers.UserSearchersByAdminiSatate
{
    public interface IUserSearcherByAdminiState
    {
        IEnumerable<UserTable> SearchInUsersByAdminiState(IEnumerable<UserTable> users, bool? adminiState);
    }
}
