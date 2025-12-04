using StationaryStoreUtility.Convertores.DateConvertors;
using StationaryStoreUtility.Validators.TextValidators;
using StationeryStoreUILayer.Forms.HomeForms;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.FormClosers;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.LableSeters;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.ProductManagemenAccessControllers;
using StationeryStoreUILayer.Forms.LoginForms.LoginHelpers.AdminCheckers;
using StationeryStoreUILayer.Forms.LoginForms.LoginHelpers.UserValidators;
using StationeryStoreUILayer.Forms.SignUpForms;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.AdminiCodeValidator;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.AdminModeChanger;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.UniqeUserValidators;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.UserBulider;
using StationeryStoreUILayer.PublicHelpers.Restartors.TextBoxRestartors;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.LoginForms.LoginHelpers.FormOpeners
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
