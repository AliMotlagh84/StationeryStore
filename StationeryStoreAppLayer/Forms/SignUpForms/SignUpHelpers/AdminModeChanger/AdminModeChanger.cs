using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.AdminModeChanger
{
    public class AdminModeChanger : IAdminModeChanger
    {
        public void ChangeAdminiMode(ref bool isAdmin, ref RadioButton rbAdmin, ref RadioButton rbUser, ref TextBox txtAdminiCode, ref Label AdminiLbl)
        {
            if (rbAdmin.Checked)
            {
                isAdmin = true;
                txtAdminiCode.Visible= true;
                AdminiLbl.Visible= true;

            }
            else if (rbUser.Checked) { 
                isAdmin = false;
                txtAdminiCode.Visible = false;
                AdminiLbl.Visible = false;
            }
        }
    }
}
