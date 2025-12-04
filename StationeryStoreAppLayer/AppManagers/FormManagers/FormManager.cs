using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.AppManagers.FormManagers
{
    public class FormManager : IFormManager
    {
        public void ManageForm(Form form)
        {
            form.FormClosed += OnFormClosed;
        }
        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {                
                Application.Exit();
            }

        }



    }
}
