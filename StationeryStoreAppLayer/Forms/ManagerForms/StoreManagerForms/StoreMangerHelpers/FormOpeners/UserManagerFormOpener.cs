using StationeryStoreAppLayer.Forms.ManagerForms.UsersManagerForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ManagerForms.StoreManagerForms.StoreMangerHelpers.FormOpeners
{
    public class UserManagerFormOpener<TUserManagerForm> : IUserManagerFormOpener where TUserManagerForm: Form, IUsersManagerForm
    {
        private TUserManagerForm _userManagerForm;

        public UserManagerFormOpener(TUserManagerForm userManagerForm)
        {
            _userManagerForm = userManagerForm;
        }
        public void OpenUserManagerForm(Form senderForm)
        {
            senderForm.Hide();
            _userManagerForm.ShowDialog();
            senderForm.Show();
        }
    }

    public interface IUserManagerForm
    {
    }
}
