using StationaryStoreUtility.Validators.EmailValidator;
using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreUILayer.AppManagers.AppRestartors;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.UserDataBuilder;
using StationeryStoreUILayer.PublicHelpers.DataEditors.UserDataEditors;
using StationeryStoreUILayer.PublicHelpers.TextBoxFillers;
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
using StationeryStoreUILayer.Forms.EditorForms.UserEditorForms;

namespace StationeryStoreUILayer.Forms.UserEditorForms
{
    public partial class UserEditorForm : Form,
        IUserEditorForm,
        ITextBoxFiller,
        ITextValidator,
        IEmailValidator,
        IAppRestartor
    {
        private UserTable userInfo;
        private ITextBoxFiller _textBoxFiller;
        private IUserDataEditor _userDataEditor;
        private IUserDataBuilder _userDataBuilder;
        private ITextValidator _textValidator;
        private IEmailValidator _emailValidator;
        private IAppRestartor _appRestartor;    
        public UserEditorForm(
            ITextBoxFiller textBoxFiller,
            IUserDataBuilder userDataBuilder,
            IUserDataEditor userDataEditor,
            ITextValidator textValidator,
            IEmailValidator emailValidator,
            IAppRestartor appRestartor)
        {
            InitializeComponent();
            _textBoxFiller = textBoxFiller;
            _userDataEditor = userDataEditor;
            _userDataBuilder = userDataBuilder;
            _textValidator = textValidator;
            _emailValidator = emailValidator;
            _appRestartor = appRestartor;

        }

        UserTable IUserEditorForm.UserInfo { get => userInfo; set => userInfo = value; }

        public UserTable BuildUserData(string userName, string userPassword, bool isAdmin, string? email, int? userIdForEdit)
        {
            return _userDataBuilder.BuildUserData(userName, userPassword, isAdmin, email, userIdForEdit);
        }

        public void EditUserData(UserTable userToEdit)
        {
            _userDataEditor.EditUserData(userToEdit);
        }

        public void FillTextBox(TextBox textBox, string text)
        {
            _textBoxFiller.FillTextBox(textBox, text);
        }

        private void UserEditorForm_Load(object sender, EventArgs e)
        {
            FillTextBox(NewPasswordtxt, userInfo.Password);
            FillTextBox(NewEmaitxt, userInfo.Email);
        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            if (ValidateText(NewPasswordtxt.Text) && ValidateText(NewEmaitxt.Text))
            {
                if (ValidateEmail(NewEmaitxt.Text))
                {
                    var newUserData = BuildUserData(userInfo.UserName, NewPasswordtxt.Text, userInfo.IsAdmin, NewEmaitxt.Text, userInfo.UserId);
                    EditUserData(newUserData);
                    MessageBox.Show("اطلاعات با موفقیت ویرایش شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetApp();
                }
                else
                {
                    MessageBox.Show("ایمیل نامعتبر است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("رمز عبور و ایمیل را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool ValidateText(string text)
        {
            return _textValidator.ValidateText(text);
        }

        public bool ValidateEmail(string email)
        {
            return _emailValidator.ValidateEmail(email);
        }

        public void ResetApp()
        {
            _appRestartor.ResetApp();
        }
    }
}
