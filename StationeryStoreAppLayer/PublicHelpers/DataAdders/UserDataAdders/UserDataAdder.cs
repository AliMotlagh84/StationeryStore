using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataAdders.UserDataAdders
{
    public class UserDataAdder : IUserDataAdder
    {
        public void AddUserData(UserTable newUser)
        {
            using(EfUnitOfWork db = new EfUnitOfWork())
            {
                db.UserRepository.Add(newUser);
                db.Save();
            }
        }
    }
}
