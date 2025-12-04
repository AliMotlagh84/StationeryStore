using StationaryStoreViewModels.EfViewModels.UserTableViewModels;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.UniqeUserValidators
{
    public class UniqeUserAndPasswordValidator : IUniqeUserValidator
    {
        public bool IsUserUniqe(string username, string password, string email)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                return db.UserRepository.IsUniqe(new SignUpVM(username, password,email));
            }
        }
    }
}
