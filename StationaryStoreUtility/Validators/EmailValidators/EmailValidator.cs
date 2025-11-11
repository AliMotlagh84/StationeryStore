using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryStoreUtility.Validators.EmailValidator
{
    public class EmailValidator : IEmailValidator
    {
        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
    }
}
