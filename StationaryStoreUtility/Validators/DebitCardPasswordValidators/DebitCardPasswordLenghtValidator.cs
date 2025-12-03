using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryStoreUtility.Validators.DebitCardPasswordValidators
{
    public class DebitCardPasswordLenghtValidator : IDebitCardPasswordLenghtValidator
    {
        public bool IsDebitCardPasswordLenghtValid(int password)
        {
            string passwordString = password.ToString();
            if ((passwordString.Length < 4)|| (passwordString.Length > 8))
            {
                return false;
            }
            else{

                return true;
            }

        }
    }
}
