using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryStoreUtility.Validators.EmailValidator
{
    public interface IEmailValidator
    {
        bool ValidateEmail(string email);
    }
}
