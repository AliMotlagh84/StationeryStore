using StationeryStoreAppLayer.Forms.UserEditorForms;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.FormOpeners
{
    public class UserEditorFormOpener<TuserEditorForm> : IUserEditorFormOpener  where TuserEditorForm : Form,IUserEditorForm
    {
        private TuserEditorForm _userEditorForm;
        public UserEditorFormOpener(TuserEditorForm userEditorForm)
        {
            _userEditorForm = userEditorForm;
        }
        public void OpenUserEditorForm(UserTable userInfo)
        {
            _userEditorForm.UserInfo = userInfo;
            _userEditorForm.ShowDialog();
        }
    }
}
