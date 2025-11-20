using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.SignUpValidateHandlers.UserSignUpValidateHandlers
{
    public interface IUserSignUpValidateHandler
    {
        bool ValidateUserSignUp(string userName, string password, string? email);

    }
}
