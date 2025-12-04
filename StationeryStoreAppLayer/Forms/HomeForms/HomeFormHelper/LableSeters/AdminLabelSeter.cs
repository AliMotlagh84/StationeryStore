using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.LableSeters
{
    public class AdminLabelSeter : IAdminLabelSeter
    {
        public void SetAdminLabel(ToolStripLabel AdminLabel, string userName, bool isAdmin)
        {
            AdminLabel.Text = userName;
            if (isAdmin)
            {
                AdminLabel.Image = StationeryStoreUILayer.Properties.Resources.icons8_admin_50;
            }
        }
    }
}
