using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.FormOpeners
{
    public interface IUserEditorFormOpener
    {
        void OpenUserEditorForm(UserTable userInfo);
    }
}
