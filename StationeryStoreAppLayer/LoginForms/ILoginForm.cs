using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreAppLayer.LoginForms.LoginHelpers.AdminCheckers;
using StationeryStoreAppLayer.LoginForms.LoginHelpers.FormOpeners;
using StationeryStoreAppLayer.LoginForms.LoginHelpers.UserValidators;
using StationeryStoreAppLayer.PublicHelpers.Restartors.TextBoxRestartors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.LoginForms
{
    public interface ILoginForm : ILoginUserValidator , IHomeFormOpener , IAdminChecker , ITextValidator , ISignUpFormOpener , ITextBoxRestartor
    {
        
    }
}
