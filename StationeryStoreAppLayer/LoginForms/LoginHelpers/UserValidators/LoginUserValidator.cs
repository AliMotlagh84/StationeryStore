using StationaryStoreViewModels.EfViewModels.UserTableViewModels;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.LoginForms.LoginHelpers.UserValidators
{
    public class LoginUserValidator : ILoginUserValidator
    {
        public bool ValidateUser(string username, string password)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                return db.UserRepository.HasUser(new LoginUserVM(username, password)); 
            }




        }
    }
}
