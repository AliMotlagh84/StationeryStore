using StationaryStoreViewModels.EfViewModels.UserTableViewModels;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.UserValidators
{
    public interface ILoginUserValidator
    {
        public bool ValidateUser(string username,string password);

    }
}
