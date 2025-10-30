using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreDataLayer.Models;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.AdminiCodeValidator;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.AdminModeChanger;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.UniqeUserValidators;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.UserBulider;
using StationeryStoreAppLayer.PublicHelpers.Restartors.TextBoxRestartors;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreAppLayer.Forms.SignUpForms
{
    public partial class SignUpForm : Form, ISignUpForm
    {
        private bool _isAdmin = false;
        private ITextValidator _textValidator;
        private IUniqeUserValidator _uniqeUserValidator;
        private IAdminModeChanger _adminModeChanger;
        private IAdminiCodeValidator _adminiCodeValidator;
        private IUserBuilder _userBuilder;
        private ITextBoxRestartor _textBoxRestartor;

        public SignUpForm(
            ITextValidator textValidator,
            IUniqeUserValidator uniqeUserValidator,
            IAdminModeChanger adminModeChanger,
            IAdminiCodeValidator adminiCodeValidator,
            IUserBuilder userBuilder,
            ITextBoxRestartor textBoxRestartor
            )
        {
            InitializeComponent();
            _textValidator = textValidator;
            _uniqeUserValidator = uniqeUserValidator;
            _adminModeChanger = adminModeChanger;
            _adminiCodeValidator = adminiCodeValidator;
            _userBuilder = userBuilder;
            _textBoxRestartor = textBoxRestartor;
        }

        private void handelSignUp(string userName, string password, string? email, string adminiCode)
        {
            if (_isAdmin)
            {
                if (ValidateText(userName) && ValidateText(password) && ValidateText(adminiCode))
                {
                    if (IsUserUniqe(userName, password, email))
                    {
                        if (ValidateAdminiCode(adminiCode))
                        {
                            using (EfUnitOfWork db = new EfUnitOfWork())
                            {
                                db.UserRepository.Add(BuildUser(userName, password, email, true));
                                db.Save();
                            }
                            RestartTextBox(txtUserName,txtPassword,txtEmail,txtAdminiCode);
                            MessageBox.Show("ادمین با موفقیت به جدول افزوده شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("کد ادمینی اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("این ادمبن از قبل وجود دارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("نام کاربری , رمز عبور و کد ادمین نباید خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (ValidateText(userName) && ValidateText(password))
                {
                    if (IsUserUniqe(userName, password, email))
                    {
                        using (EfUnitOfWork db = new EfUnitOfWork())
                        {
                            db.UserRepository.Add(BuildUser(userName, password, email, false                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       ));
                            db.Save();

                        }
                        RestartTextBox(txtUserName, txtPassword, txtEmail, txtAdminiCode);
                        MessageBox.Show("کاربر با موفقیت به جدول افزوده شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("این کاربر از قبل وجود دارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("نام کاربری و رمز عبور نباید خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool ValidateText(string text)
        {
            return _textValidator.ValidateText(text);

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            RbUser.Checked = true;
        }

        public bool IsUserUniqe(string username, string password, string email)
        {
            return _uniqeUserValidator.IsUserUniqe(username, password, email);
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

        public bool ValidateAdminiCode(string adminiCode)
        {
            return _adminiCodeValidator.ValidateAdminiCode(adminiCode);
        }

        public UserTable BuildUser(string username, string password, string? email, bool isAdmin)
        {
            return _userBuilder.BuildUser(username, password, email, isAdmin);
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
    }
}
