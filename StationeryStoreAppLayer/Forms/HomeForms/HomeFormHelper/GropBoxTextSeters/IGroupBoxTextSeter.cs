using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.GropBoxTextSeters
{
    public interface IGroupBoxTextSeter
    {
        void SetGroupBoxText(GroupBox gb, string text, bool? where = null);
    }
}
