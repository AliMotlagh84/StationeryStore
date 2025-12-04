using StationaryStoreViewModels.EfViewModels.UserTableViewModels;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.LoginForms.LoginHelpers.UserValidators
{
    public interface ILoginUserValidator
    {
        public bool ValidateUser(string username,string password);

    }
}
