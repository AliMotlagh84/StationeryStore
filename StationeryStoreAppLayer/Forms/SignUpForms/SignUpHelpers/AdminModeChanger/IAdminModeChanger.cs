using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.AdminModeChanger
{
    public interface IAdminModeChanger
    {
       void ChangeAdminiMode(ref bool isAdmin,ref RadioButton rbAdmin,ref RadioButton rbUser,ref TextBox txtAdminiCode,ref Label AdminiLbl);
    }
}
