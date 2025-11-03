using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataDeleter.UserDataDeleters
{
    public interface IUserDataDeleterById
    {
        void DeleteUserData(object userId);
    }
}
