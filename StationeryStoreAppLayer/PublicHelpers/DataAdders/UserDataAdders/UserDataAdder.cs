using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataAdders.UserDataAdders
{
    public class UserDataAdder : IUserDataAdder
    {
        public void Add(UserTable newUser)
        {
            using(EfUnitOfWork db = new EfUnitOfWork())
            {
                db.UserRepository.Add(newUser);
                db.Save();
            }
        }
    }
}
