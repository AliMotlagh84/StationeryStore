using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.GroupBoxTextSeter
{
    public interface IGroupBoxTextSeter
    {
        void SetGroupBoxText(GroupBox gb, string text, bool? where = null);
    }
}
