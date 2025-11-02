using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataEditors.UserDataEditors
{
    public interface IUserDataEditor
    {
        void EditUserData(UserTable userToEdit);
    }
}
