using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.UniqeUserValidators
{
    public interface IUniqeUserValidator
    {
        bool IsUserUniqe(string username, string password,string email);
    }
}
