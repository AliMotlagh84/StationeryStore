using StationaryStoreUtility.Validators.EmailValidator;
using StationeryStoreUILayer.PublicHelpers.DataAdders.UserDataAdders;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.UserDataBuilder;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.UserDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.UserDataGeters;
using StationeryStoreUILayer.PublicHelpers.DgFillers;
using StationeryStoreUILayer.PublicHelpers.Restartors.TextBoxRestartors;
using StationeryStoreUILayer.PublicHelpers.Searchers.UserSearchers;
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
using StationerStoreApplicationLayer.Deleters.UserDeleters;

namespace StationeryStoreUILayer.Forms.ManagerForms.UsersManagerForms
{
    public partial class UsersManagerForm : Form, IUsersManagerForm,
        IUsersDataGeter,
        IUserDataBuilder,
        IUserSeacher,
        IUserDeleter,
        ITextBoxRestartor,
        IDgFiller

    {
        private IUsersDataGeter _usersDataGeter;
        private IUserSeacher _userSeacher;
        private IUserDataBuilder _userDataBuilder;
        private IUserDeleter _userDeleter;
        private ITextBoxRestartor _textBoxRestartor;
        private IDgFiller _dgFiller;

        public UsersManagerForm(IUsersDataGeter usersDataGeter,
            IUserSeacher userSeacher,
            IUserDataBuilder userDataBuilder,
            IUserDeleter userDeleter,
            ITextBoxRestartor textBoxRestartor,
            IDgFiller dgFiller)
        {
            InitializeComponent();
            _usersDataGeter = usersDataGeter;
            _userSeacher = userSeacher;
            _userDataBuilder = userDataBuilder;
            _userDeleter = userDeleter;
            _textBoxRestartor = textBoxRestartor;
            _dgFiller = dgFiller;
        }

        public UserTable BuildUserData(string userName, string userPassword, bool isAdmin, string? email, int? userIdForEdit = null)
        {
            return _userDataBuilder.BuildUserData(userName, userPassword, isAdmin, email, userIdForEdit);
        }

        public void DeleteUser(object userId)
        {
            _userDeleter.DeleteUser(userId);
        }

        public void DeleteUser(UserTable user)
        {
            _userDeleter.DeleteUser(user);
        }

        public List<UserTable> GetUsersData()
        {
            return _usersDataGeter.GetUsersData();
        }

        private void UsersManagerForm_Load(object sender, EventArgs e)
        {
            FillDg(UsersDg, SearchInUsers(GetUsersData(), null, null, null, null, false));
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        void RefreshForm()
        {
            FillDg(UsersDg, SearchInUsers(GetUsersData(), null, null, null, null, false));
            RestartTextBox(txtUserEmail, txtUserName);
        }

        public List<UserTable> SearchInUsers(IEnumerable<UserTable> users, int? userId = null, string? username = null, string? userPassword = null, string? userEmail = null, bool? isAdmin = null)
        {
            return _userSeacher.SearchInUsers(users, userId, username, userPassword, userEmail, isAdmin);
        }

        public void RestartTextBox(params TextBox[] textBoxes)
        {
            _textBoxRestartor.RestartTextBox(textBoxes);
        }

        private void UsersSearchBtn_Click(object sender, EventArgs e)
        {
            FillDg(UsersDg, SearchInUsers(GetUsersData(), null, txtUserName.Text, null, txtUserEmail.Text, false));
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            if (UsersDg.CurrentRow != null)
            {
                var currentRowCells = UsersDg.CurrentRow.Cells;

                if (MessageBox.Show($"از حذف {(string)currentRowCells[1].Value} مطمئن هستید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DeleteUser((int)currentRowCells[0].Value);
                    RefreshForm();
                }

            }
            else
            {
                MessageBox.Show("کاربری انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FillDg<T>(DataGridView dg, List<T> data)
        {
            _dgFiller.FillDg(dg, data);
        }

    }
}
