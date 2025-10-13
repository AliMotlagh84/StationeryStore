using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.LoginForms.LoginHelpers.AdminCheckers
{
    public interface IAdminChecker
    {
        bool IsAdmin(string userName , string Password);
    }
}
