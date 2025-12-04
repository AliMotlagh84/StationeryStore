using StationaryStoreUtility.Convertores.DateConvertors;
using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreUILayer.AppManagers.FormManagers;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.FormClosers;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.LableSeters;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.ProductManagemenAccessControllers;
using StationeryStoreUILayer.Forms.LoginForms.LoginHelpers.AdminCheckers;
using StationeryStoreUILayer.Forms.LoginForms.LoginHelpers.FormOpeners;
using StationeryStoreUILayer.Forms.LoginForms.LoginHelpers.UserValidators;
using StationeryStoreUILayer.LoginForms;
using StationeryStoreUILayer.PublicHelpers.DataGeters.UserDataGeters;
using StationeryStoreUILayer.PublicHelpers.Restartors.TextBoxRestartors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.AppManagers.ApplicationContexts
{
    public class StationeryApplicationContext : ApplicationContext ,IFormManager
    {
        private Login loginForm;
        private IFormManager formManager;
        public StationeryApplicationContext(ILoginUserValidator loginUserValidator,
          IHomeFormOpener homeFormOpener,
          ISingleUserDataGeterByNameAndPassword singleUserDataGeterByNameAndPassword,
          ITextValidator textValidator,
          ISignUpFormOpener signUpFormOpener,
          ITextBoxRestartor textBoxRestartor,
          IFormManager formManager)
        {
            this.formManager = formManager;
            loginForm = new Login(loginUserValidator, homeFormOpener, singleUserDataGeterByNameAndPassword, textValidator, signUpFormOpener, textBoxRestartor);
            ManageForm(loginForm);
            loginForm.Show();
        }

        public void ManageForm(Form form)
        {
            formManager.ManageForm(form);
        }

        public void ResetApp()
        {
            Application.Restart();
        }
    }
}
