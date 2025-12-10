using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Deleters.UserDeleters
{
    public interface IUserDeleter
    {
        void DeleteUser(object userId);
        void DeleteUser(UserTable user);
    }
}
