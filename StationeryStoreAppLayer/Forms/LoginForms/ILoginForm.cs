using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreUILayer.Forms.LoginForms.LoginHelpers.AdminCheckers;
using StationeryStoreUILayer.Forms.LoginForms.LoginHelpers.FormOpeners;
using StationeryStoreUILayer.Forms.LoginForms.LoginHelpers.UserValidators;
using StationeryStoreUILayer.PublicHelpers.DataGeters.UserDataGeters;
using StationeryStoreUILayer.PublicHelpers.Restartors.TextBoxRestartors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.LoginForms
{
    public interface ILoginForm : ILoginUserValidator ,ISingleUserDataGeterByNameAndPassword, IHomeFormOpener, ITextValidator , ISignUpFormOpener , ITextBoxRestartor
    {
        
    }
}
