using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.FormOpeners
{
    public interface IHomeFormOpener
    {
        void OpenHomeForm(bool isAdmin,string userName);
    }
}
