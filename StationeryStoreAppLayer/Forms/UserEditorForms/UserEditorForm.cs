using StationeryStoreAppLayer.PublicHelpers.DataBuilders.UserDataBuilder;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.UserDataEditors;
using StationeryStoreAppLayer.PublicHelpers.TextBoxFillers;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreAppLayer.Forms.UserEditorForms
{
    public partial class UserEditorForm : Form, IUserEditorForm, ITextBoxFiller
    {
        private UserTable userInfo;
        private ITextBoxFiller _textBoxFiller;
        private IUserDataEditor _userDataEditor;
        private IUserDataBuilder _userDataBuilder;
        public UserEditorForm(
            ITextBoxFiller textBoxFiller,
            IUserDataBuilder userDataBuilder,
            IUserDataEditor userDataEditor
            )
        {
            InitializeComponent();
            _textBoxFiller = textBoxFiller;
            _userDataEditor = userDataEditor;
            _userDataBuilder = userDataBuilder;
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
            var newUserData = BuildUserData(userInfo.UserName,NewPasswordtxt.Text,userInfo.IsAdmin,NewEmaitxt.Text,userInfo.UserId);           
            EditUserData(newUserData);
            MessageBox.Show("اطلاعات با موفقیت ویرایش شد","",MessageBoxButtons.OK,MessageBoxIcon.Information);           
            DialogResult = DialogResult.OK;
        }
    }
}
