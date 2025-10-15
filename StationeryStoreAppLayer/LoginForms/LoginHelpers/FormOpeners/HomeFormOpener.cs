using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.LoginForms.LoginHelpers.FormOpeners
{
    public class HomeFormOpener<T> : IHomeFormOpener where T : Form, IHomeForm
    {
        private T homeForm;
        public HomeFormOpener(T homeForm)
        {
            this.homeForm = homeForm;
        }
        public void OpenHomeForm(bool isAdmin) 
        {
            homeForm.IsAdmin = isAdmin;
            homeForm?.ShowDialog();

        }
    }
}
