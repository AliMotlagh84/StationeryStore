using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.AdminiCodeValidator;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.UniqeUserValidators;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.UserBulider;
using StationeryStoreUILayer.PublicHelpers.Restartors.TextBoxRestartors;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StationaryStoreUtility.Validators.EmailValidator;
using StationeryStoreUILayer.PublicHelpers.DataAdders.UserDataAdders;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.UserDataBuilder;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.AdminModeChanger;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.SignUpValidateHandlers.AdminSignUpValidateHandlers;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.SignUpValidateHandlers.UserSignUpValidateHandlers;

namespace StationeryStoreUILayer.Forms.SignUpForms
{
    public partial class SignUpForm : Form,
        ISignUpForm,
        IAdminSignUpValidateHandler,
        IUserSignUpValidateHandler,
        IAdminModeChanger,
        ITextBoxRestartor


    {
        private bool _isAdmin = false;
        private IAdminModeChanger _adminModeChanger;
        private IUserDataBuilder _userDataBuilder;
        private IUserDataAdder _userDataAdder;
        private ITextBoxRestartor _textBoxRestartor;
        private IAdminSignUpValidateHandler _adminSignUpValidateHandler;
        private IUserSignUpValidateHandler _userSignUpValidateHandlerHandler;

        public SignUpForm(
            IAdminSignUpValidateHandler adminSignUpValidateHandler,
            IUserSignUpValidateHandler userSignUpValidateHandler,
            IUserDataBuilder userDataBuilder,
            IUserDataAdder userDataAdder,
            IAdminModeChanger adminModeChanger,
            ITextBoxRestartor textBoxRestartor
            )
        {
            InitializeComponent();
            _adminSignUpValidateHandler = adminSignUpValidateHandler;
            _userSignUpValidateHandlerHandler = userSignUpValidateHandler;
            _userDataBuilder = userDataBuilder;
            _userDataAdder = userDataAdder;
            _adminModeChanger = adminModeChanger;       
            _textBoxRestartor = textBoxRestartor;
        }

        private void handelSignUp(string userName, string password, string? email, string adminiCode)
        {
            if (_isAdmin)
            {
                if (ValidateAdminSignUp(userName,password,email,adminiCode))
                {
                    AddUserData(BuildUserData(userName,password,true,email));
                    MessageBox.Show("ادمین با موفقیت به جدول افزوده شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestartTextBox(txtUserName, txtPassword, txtEmail, txtAdminiCode);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                if (ValidateUserSignUp(userName,password,email))
                {
                    AddUserData(BuildUserData(userName, password,false, email));
                    MessageBox.Show("کاربر با موفقیت به جدول افزوده شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestartTextBox(txtUserName, txtPassword, txtEmail, txtAdminiCode);
                    DialogResult = DialogResult.OK;
                }

            }
        }



        private void SignUpForm_Load(object sender, EventArgs e)
        {
            RbUser.Checked = true;
        }

        public void ChangeAdminiMode(ref bool isAdmin, ref RadioButton rbAdmin, ref RadioButton rbUser, ref TextBox txtAdminiCode, ref Label AdminiLbl)
        {
            _adminModeChanger.ChangeAdminiMode(ref isAdmin, ref rbAdmin, ref rbUser, ref txtAdminiCode, ref AdminiLbl);
        }

        private void RbUser_CheckedChanged(object sender, EventArgs e)
        {
            ChangeAdminiMode(ref _isAdmin, ref RbAdmin, ref RbUser, ref txtAdminiCode, ref AdminiCodeLbl);
        }

        private void RbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            ChangeAdminiMode(ref _isAdmin, ref RbAdmin, ref RbUser, ref txtAdminiCode, ref AdminiCodeLbl);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            handelSignUp(txtUserName.Text, txtPassword.Text, txtEmail.Text, txtAdminiCode.Text);
        }

        private void SingUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        public void RestartTextBox(params TextBox[] textBoxes)
        {
            _textBoxRestartor.RestartTextBox(textBoxes);
        }

        public bool ValidateAdminSignUp(string userName, string password, string? email, string adminiCode)
        {
            return _adminSignUpValidateHandler.ValidateAdminSignUp(userName, password, email, adminiCode);
        }

        public bool ValidateUserSignUp(string userName, string password, string? email)
        {
           return _userSignUpValidateHandlerHandler.ValidateUserSignUp(userName,password,email);
        }

        public void AddUserData(UserTable newUser)
        {
           _userDataAdder.AddUserData(newUser);
        }

        public UserTable BuildUserData(string userName, string userPassword, bool isAdmin, string? email, int? userIdForEdit = null)
        {
          return  _userDataBuilder.BuildUserData(userName,userPassword,isAdmin,email);

        }
    }
}
