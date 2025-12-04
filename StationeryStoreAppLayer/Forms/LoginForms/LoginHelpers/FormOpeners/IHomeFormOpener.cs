using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.LoginForms.LoginHelpers.FormOpeners
{
    public interface IHomeFormOpener
    {
        void OpenHomeForm(UserTable userInfo,Form senderForm);
    }
}
