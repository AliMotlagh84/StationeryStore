using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.AdminCheckers;
using StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.FormOpeners;
using StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.UserValidators;
using StationeryStoreAppLayer.PublicHelpers.Restartors.TextBoxRestartors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.LoginForms
{
    public interface ILoginForm : ILoginUserValidator , IHomeFormOpener , IAdminChecker , ITextValidator , ISignUpFormOpener , ITextBoxRestartor
    {
        
    }
}
