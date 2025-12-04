using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers
{
    public interface IUserSeacher
    {
        List<UserTable> SearchInUsers(IEnumerable<UserTable> users, int? userId = null, string? username = null, string? userPassword = null, string? userEmail = null , bool? isAdmin = null);
    }
}
