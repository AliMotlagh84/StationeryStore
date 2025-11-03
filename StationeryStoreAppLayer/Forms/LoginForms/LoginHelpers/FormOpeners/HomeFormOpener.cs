using StationaryStoreUtility.Convertores.DateConvertors;
using StationaryStoreUtility.Validators.TextValidators;
using StationeryStoreAppLayer.Forms.HomeForms;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.FormClosers;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.LableSeters;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.ProductManagemenAccessControllers;
using StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.AdminCheckers;
using StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.UserValidators;
using StationeryStoreAppLayer.Forms.SignUpForms;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.AdminiCodeValidator;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.AdminModeChanger;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.UniqeUserValidators;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.UserBulider;
using StationeryStoreAppLayer.PublicHelpers.Restartors.TextBoxRestartors;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.FormOpeners
{
    public class HomeFormOpener<T> : IHomeFormOpener where T : Form, IHomeForm
    {
        private T _homeForm;
        public HomeFormOpener(T homeForm)
        {
            _homeForm = homeForm;
        }

        public void OpenHomeForm(UserTable userInfo, Form senderForm)
        {
            _homeForm.UserInfo = userInfo;
            _homeForm.SenderForm = senderForm;
            _homeForm?.Show();
        }
    }
}
