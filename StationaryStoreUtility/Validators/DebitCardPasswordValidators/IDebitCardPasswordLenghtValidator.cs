using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryStoreUtility.Validators.DebitCardPasswordValidators
{
    public interface IDebitCardPasswordLenghtValidator
    {
        public bool IsDebitCardPasswordLenghtValid(int password);
    }
}
