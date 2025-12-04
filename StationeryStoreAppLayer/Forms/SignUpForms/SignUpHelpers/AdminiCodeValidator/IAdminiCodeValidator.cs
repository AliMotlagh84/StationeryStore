using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.AdminiCodeValidator
{
    public interface IAdminiCodeValidator
    {
        bool ValidateAdminiCode(string adminiCode);
    }
}
