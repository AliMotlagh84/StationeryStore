using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.AdminiCodeValidator;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.AdminModeChanger;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.UniqeUserValidators;
using StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.UserBulider;
using StationeryStoreUILayer.PublicHelpers.DataAdders.UserDataAdders;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.UserDataBuilder;
using StationeryStoreUILayer.PublicHelpers.Restartors.TextBoxRestartors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.SignUpForms
{
    public interface ISignUpForm :    
        IUserDataAdder,
        IUserDataBuilder
    {
    }
}
