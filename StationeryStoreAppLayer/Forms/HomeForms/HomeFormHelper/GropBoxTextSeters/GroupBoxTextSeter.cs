using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.GropBoxTextSeters
{
    public class GroupBoxTextSeter : IGroupBoxTextSeter
    {
        public void SetGroupBoxText(GroupBox gb, string text, bool? where = null)
        {
            if(where == null)
            {
                gb.Text = text;
            }
            else
            {
                if ((bool)where)
                {
                    gb.Text = text;
                }
            }
        }
    }
}
