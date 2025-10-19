using StationeryStoreAppLayer.Forms.SignUpForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.FormOpeners
{
    public class SignUpFormOpener<T> : ISignUpFormOpener where T : Form , ISignUpForm
    {
        T _signUpForm;

        public SignUpFormOpener(T signUpForm)
        {
            _signUpForm = signUpForm;
        }
        public void OpenSignUpForm()
        {
            _signUpForm.ShowDialog();
        }
    }
}
