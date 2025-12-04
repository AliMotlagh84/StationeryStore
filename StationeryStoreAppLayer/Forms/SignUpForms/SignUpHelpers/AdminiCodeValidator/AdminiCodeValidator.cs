using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.AdminiCodeValidator
{
    public class AdminiCodeValidator : IAdminiCodeValidator
    {
        public bool ValidateAdminiCode(string adminiCode)
        {
            return adminiCode == "84899701";
        }
    }
}
