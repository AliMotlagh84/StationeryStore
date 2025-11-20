using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.SignUpValidateHandlers.AdminSignUpValidateHandlers
{
    public interface IAdminSignUpValidateHandler
    {
        bool ValidateAdminSignUp(string userName, string password, string? email, string adminiCode);
    }
}
