using StationaryStoreViewModels.EfViewModels.UserTableViewModels;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.LoginForms.LoginHelpers.AdminCheckers
{
    public class AdminChecker : IAdminChecker
    {
        public bool IsAdmin(string userName, string password)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
              return  db.UserRepository.IsAdmin(new LoginUserVM(userName,password));
            }
        }
    }
}
