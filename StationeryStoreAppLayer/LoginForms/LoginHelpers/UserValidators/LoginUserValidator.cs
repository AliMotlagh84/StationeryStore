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
            bool dataBaseHasUser;
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                if (db.UserRepository.HasUser(new LoginUserVM(username, password)))
                {
                    dataBaseHasUser = true;
                }
                else
                {
                    dataBaseHasUser = false;
                }

                return dataBaseHasUser;
            }




        }
    }
}
