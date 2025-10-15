using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreAppLayer.LoginForms.LoginHelpers.AdminCheckers;
using StationeryStoreAppLayer.LoginForms.LoginHelpers.FormOpeners;
using StationeryStoreAppLayer.LoginForms.LoginHelpers.UserValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreAppLayer.LoginForms
{
    public partial class Login : Form, ILoginForm
    {
        private ILoginUserValidator _loginUserValidator;
        private IHomeFormOpener _homeFormOpener;
        private IAdminChecker _adminChecker;
        private ITextValidator _textValidator;
        public Login(
          ILoginUserValidator loginUserValidator,
          IHomeFormOpener homeFormOpener,
          IAdminChecker adminChecker,
          ITextValidator textValidator
          )
        {
            InitializeComponent();
            _loginUserValidator = loginUserValidator;
            _homeFormOpener = homeFormOpener;
            _adminChecker = adminChecker;
            _textValidator = textValidator;
        }
        private void handelLogin(string userName, string password)
        {
            if (ValidateText(userName) && ValidateText(password))
            {
                if (ValidateUser(userName, password))
                {
                    OpenHomeForm(IsAdmin(userName, password));
                }
                else
                {
                    MessageBox.Show("کاربر یافت نشد","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("نام یا رمز عبور خالیست","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            handelLogin(txtUserName.Text, txtPassword.Text);

        }

        public bool ValidateUser(string username, string password)
        {
            return _loginUserValidator.ValidateUser(username, password);
        }



        public bool IsAdmin(string userName, string Password)
        {
            return _adminChecker.IsAdmin(userName, Password);
        }

        public bool ValidateText(string text)
        {
            return _textValidator.ValidateText(text);
        }

        public void OpenHomeForm(bool isAdmin)
        {
            _homeFormOpener.OpenHomeForm(isAdmin);
        }
    }
}
