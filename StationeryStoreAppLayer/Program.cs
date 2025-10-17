using StationaryStoreUtility.Validators.TextValidators;
using StationeryStoreAppLayer.LoginForms;
using StationeryStoreAppLayer.LoginForms.LoginHelpers.AdminCheckers;
using StationeryStoreAppLayer.LoginForms.LoginHelpers.FormOpeners;
using StationeryStoreAppLayer.LoginForms.LoginHelpers.UserValidators;
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
            Application.Run(new SignUpForm(new NullOrWhiteSpaceValidator(),new UniqeUserAndPasswordValidator(),new AdminModeChanger(),new AdminiCodeValidator(),new UserBuilder()));
        }
    }
}