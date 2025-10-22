using StationaryStoreUtility.Validators.textValidators;
using StationaryStoreUtility.Validators.TextValidators;
using StationeryStoreAppLayer.LoginForms;
using StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.AdminCheckers;
using StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.FormOpeners;
using StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.UserValidators;
using StationeryStoreAppLayer.PublicHelpers.Restartors.TextBoxRestartors;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.AdminiCodeValidator;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.AdminModeChanger;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.UniqeUserValidators;
using StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.UserBulider;
using StationeryStoreAppLayer.Forms.SignUpForms;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.ProductManagemenAccessControllers;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.LableSeters;
using StationaryStoreUtility.Convertores.DateConvertors;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.FormClosers;
using StationeryStoreAppLayer.ApplicationContexts;
using StationeryStoreAppLayer.FormManagers;

namespace StationeryStoreAppLayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            SignUpForm signUpForm = new SignUpForm(new NullOrWhiteSpaceValidator(), new UniqeUserAndPasswordValidator(), new AdminModeChanger(), new AdminiCodeValidator(), new UserBuilder(),new TextBoxRestartor());
            Form1 homeForm = new Form1(new ProductManagementAccessController(),new TimeLabelSeter(),new DateLabelSeter(new MiladiToPersianDateConvertor()),new IntroducingLabelSeter(),new AdminLabelSeter(),new FormCloser(),new FormManager());
            Application.Run(new StationeryApplicationContext(new LoginUserValidator(),new HomeFormOpener<Form1>(homeForm),new AdminChecker(),new NullOrWhiteSpaceValidator(),new SignUpFormOpener<SignUpForm>(signUpForm),new TextBoxRestartor(),new FormManager()));
        }
    }
}