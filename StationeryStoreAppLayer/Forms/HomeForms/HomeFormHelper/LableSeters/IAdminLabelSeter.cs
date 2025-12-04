using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.LableSeters
{
    public interface IAdminLabelSeter
    {
        void SetAdminLabel(ToolStripLabel AdminLabel, string userName, bool isAdmin);
 
    }
}
