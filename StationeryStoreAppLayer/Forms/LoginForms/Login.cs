using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreAppLayer.Forms.LoginForms;
using StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.AdminCheckers;
using StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.FormOpeners;
using StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.UserValidators;
using StationeryStoreAppLayer.PublicHelpers.Restartors.TextBoxRestartors;
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
        private ISignUpFormOpener _signUpFormOpener;
        private ITextBoxRestartor _textBoxRestartor;
        public Login(
          ILoginUserValidator loginUserValidator,
          IHomeFormOpener homeFormOpener,
          IAdminChecker adminChecker,
          ITextValidator textValidator, 
          ISignUpFormOpener signUpFormOpener,
          ITextBoxRestartor textBoxRestartor
          )
        {
            InitializeComponent();
            _loginUserValidator = loginUserValidator;
            _homeFormOpener = homeFormOpener;
            _adminChecker = adminChecker;
            _textValidator = textValidator;
            _signUpFormOpener = signUpFormOpener;
            _textBoxRestartor = textBoxRestartor;
        }
        private void handelLogin(string userName, string password)
        {
            if (ValidateText(userName) && ValidateText(password))
            {
                if (ValidateUser(userName, password))
                {
                    OpenHomeForm(IsAdmin(userName, password),userName,this);
                    
                }
                else
                {
                    MessageBox.Show("کاربر یافت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("نام یا رمز عبور خالیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void OpenHomeForm(bool isAdmin,string userName,Form senderForm)
        {
            _homeFormOpener.OpenHomeForm(isAdmin, userName, senderForm);
        }

        public void OpenSignUpForm()
        {
            _signUpFormOpener.OpenSignUpForm();
        }

        private void SingUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RestartTextBox(txtUserName,txtPassword);
            OpenSignUpForm();
        }

        public void RestartTextBox(params TextBox[] textBoxes)
        {
            _textBoxRestartor.RestartTextBox(textBoxes);
        }
    }
}
