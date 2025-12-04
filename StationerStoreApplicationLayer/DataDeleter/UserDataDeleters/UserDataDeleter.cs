using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataDeleter.UserDataDeleters
{
    public class UserDataDeleter : IUserDataDeleter
    {
        public void DeleteUserData(object userId)
        {

                using (EfUnitOfWork db = new EfUnitOfWork())
                {
                    db.UserRepository.Delete(userId);
                    db.Save();
                }            
        }

        public void DeleteUserData(UserTable user)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.UserRepository.Delete(user);
                db.Save();
            }
        }
    }
}
