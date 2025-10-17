using StationaryStoreUtility.Validators.textValidators;
using StationaryStoreUtility.Validators.TextValidators;
using StationeryStoreAppLayer.LoginForms;
using StationeryStoreAppLayer.LoginForms.LoginHelpers.AdminCheckers;
using StationeryStoreAppLayer.LoginForms.LoginHelpers.FormOpeners;
using StationeryStoreAppLayer.LoginForms.LoginHelpers.UserValidators;
using StationeryStoreAppLayer.PublicHelpers.Restartors.TextBoxRestartors;
using StationeryStoreAppLayer.SignUpForms;
using StationeryStoreAppLayer.SignUpForms.SignUpHelpers.AdminiCodeValidator;
using StationeryStoreAppLayer.SignUpForms.SignUpHelpers.AdminModeChanger;
using StationeryStoreAppLayer.SignUpForms.SignUpHelpers.UniqeUserValidators;
using StationeryStoreAppLayer.SignUpForms.SignUpHelpers.UserBulider;

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
            Form1 homeForm = new Form1();
            Application.Run(new Login(new LoginUserValidator(),new HomeFormOpener<Form1>(homeForm),new AdminChecker(),new NullOrWhiteSpaceValidator(),new SignUpFormOpener<SignUpForm>(signUpForm),new TextBoxRestartor()));
        }
    }
}