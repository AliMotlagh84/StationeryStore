using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataBuilders.UserDataBuilder
{
    public interface IUserDataBuilder
    {
        UserTable BuildUserData(string userName,string userPassword,bool isAdmin,string? email,int? userIdForEdit);
    }
}
