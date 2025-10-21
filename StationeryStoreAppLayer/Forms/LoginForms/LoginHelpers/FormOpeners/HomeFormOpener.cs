using StationeryStoreAppLayer.Forms.HomeForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.FormOpeners
{
    public class HomeFormOpener<T> : IHomeFormOpener where T : Form, IHomeForm
    {
        private T homeForm;
        public HomeFormOpener(T homeForm)
        {
            this.homeForm = homeForm;
        }
        public void OpenHomeForm(bool isAdmin, string userName) 
        {
            homeForm.IsAdmin = isAdmin;
            homeForm.UserName = userName;
            homeForm?.ShowDialog();        

        }
    }
}
