using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.LoginForms.LoginHelpers.FormOpeners
{
    public class HomeFormOpener : IHomeFormOpener
    {
        public void OpenHomeForm(bool isAdmin)
        {
            Form1 homeForm = new Form1(isAdmin);
            homeForm.ShowDialog();
        }
    }
}
