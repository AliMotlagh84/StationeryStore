using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataDeleter.UserDataDeleters
{
    public class UserDataDeleterById : IUserDataDeleterById
    {
        public void DeleteUserData(object userId)
        {

                using (EfUnitOfWork db = new EfUnitOfWork())
                {
                    db.UserRepository.Delete(userId);
                    db.Save();
                }
            
        }
    }
}
