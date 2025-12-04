using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataBuilders.UserDataBuilder
{
    public class UserDataBuilder : IUserDataBuilder
    {
        public UserTable BuildUserData(string userName, string userPassword, bool isAdmin, string? email, int? userIdForEdit=null)
        {
            var newUserData = new UserTable()
            {
                UserName = userName,
                Password = userPassword,
                IsAdmin = isAdmin,
                Email = email,
            };
            if (userIdForEdit != null)
            {
                newUserData.UserId = (int)userIdForEdit;
            }
            return newUserData;
        }
    }
}
