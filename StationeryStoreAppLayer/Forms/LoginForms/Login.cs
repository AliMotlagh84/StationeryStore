using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreUILayer.Forms.LoginForms;
using StationeryStoreUILayer.Forms.LoginForms.LoginHelpers.AdminCheckers;
using StationeryStoreUILayer.Forms.LoginForms.LoginHelpers.FormOpeners;
using StationeryStoreUILayer.Forms.LoginForms.LoginHelpers.UserValidators;
using StationeryStoreUILayer.PublicHelpers.DataGeters.UserDataGeters;
using StationeryStoreUILayer.PublicHelpers.Restartors.TextBoxRestartors;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreUILayer.LoginForms
{
    public partial class Login : Form, ILoginForm
    {
        private ILoginUserValidator _loginUserValidator;
        private IHomeFormOpener _homeFormOpener;
        private ISingleUserDataGeterByNameAndPassword _singleUserDataGeterByNameAndPassword;
        private ITextValidator _textValidator;
        private ISignUpFormOpener _signUpFormOpener;
        private ITextBoxRestartor _textBoxRestartor;
        public Login(
          ILoginUserValidator loginUserValidator,
          IHomeFormOpener homeFormOpener,
          ISingleUserDataGeterByNameAndPassword singleUserDataGeterByNameAndPassword,
          ITextValidator textValidator,
          ISignUpFormOpener signUpFormOpener,
          ITextBoxRestartor textBoxRestartor

          )
        {
            InitializeComponent();
            _loginUserValidator = loginUserValidator;
            _homeFormOpener = homeFormOpener;
            _singleUserDataGeterByNameAndPassword = singleUserDataGeterByNameAndPassword;
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
                    OpenHomeForm(GetSingleUserDataByNameAndPassword(userName,password),this);
                    
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

        public bool ValidateText(string text)
        {
            return _textValidator.ValidateText(text);
        }

        public void OpenSignUpForm(Form senderForm)
        {
            _signUpFormOpener.OpenSignUpForm(senderForm);
        }

        private void SingUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RestartTextBox(txtUserName,txtPassword);
            OpenSignUpForm(this);
        }

        public void RestartTextBox(params TextBox[] textBoxes)
        {
            _textBoxRestartor.RestartTextBox(textBoxes);
        }

        public void OpenHomeForm(UserTable userInfo, Form senderForm)
        {
            _homeFormOpener.OpenHomeForm(userInfo, senderForm);
        }

        public UserTable GetSingleUserDataByNameAndPassword(string username, string password)
        {
            return _singleUserDataGeterByNameAndPassword.GetSingleUserDataByNameAndPassword(username, password);
        }
    }
}
