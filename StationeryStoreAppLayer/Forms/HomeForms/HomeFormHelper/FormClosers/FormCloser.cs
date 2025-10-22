using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.FormClosers
{
    public class FormCloser : IFormCloser
    {

        public void CloseForm(Form form)
        {
            form.Close();  
        }
    }
}
