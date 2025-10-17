using StationaryStoreUtility.Validators.textValidators;
using StationeryStoreAppLayer.SignUpForms.SignUpHelpers.AdminiCodeValidator;
using StationeryStoreAppLayer.SignUpForms.SignUpHelpers.AdminModeChanger;
using StationeryStoreAppLayer.SignUpForms.SignUpHelpers.UniqeUserValidators;
using StationeryStoreAppLayer.SignUpForms.SignUpHelpers.UserAdder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.SignUpForms
{
    public interface ISignUpForm : ITextValidator , IUniqeUserValidator , IAdminModeChanger , IAdminiCodeValidator , IUserBuilder
    {
    }
}
