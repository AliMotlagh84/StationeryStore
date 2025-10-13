using StationaryStoreUtility.Validators.textValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryStoreUtility.Validators.TextValidators
{
    public class NullOrWhiteSpaceValidator : ITextValidator
    {
        public bool ValidateText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }
            return true;
        }
    }
}
