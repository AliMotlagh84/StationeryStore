using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Editors.UserEditors
{
    public interface IUserEditor
    {
        void EditUser(UserTable userInfo);
    }
}
