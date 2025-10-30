using StationaryStoreUtility.Convertores.DateConvertors;
using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreAppLayer.FormManagers;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.FormClosers;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.LableSeters;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.ProductManagemenAccessControllers;
using StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.AdminCheckers;
using StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.FormOpeners;
using StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.UserValidators;
using StationeryStoreAppLayer.LoginForms;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.UserDataGeters;
using StationeryStoreAppLayer.PublicHelpers.Restartors.TextBoxRestartors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.ApplicationContexts
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
    }
}
