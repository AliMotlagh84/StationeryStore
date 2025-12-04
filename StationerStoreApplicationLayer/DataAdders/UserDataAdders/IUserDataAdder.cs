using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataAdders.UserDataAdders
{
    public interface IUserDataAdder
    {
        void AddUserData(UserTable newUser);
    }
}
