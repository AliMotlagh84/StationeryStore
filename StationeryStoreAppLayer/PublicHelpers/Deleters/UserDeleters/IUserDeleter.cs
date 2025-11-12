using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Deleters.UserDeleters
{
    public interface IUserDeleter
    {
        void DeleteUser(object userId);
        void DeleteUser(UserTable user);
    }
}
