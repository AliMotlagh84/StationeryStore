using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataGeters.UserDataGeters
{
    public class UsersDataGeter : IUsersDataGeter
    {
        public List<UserTable> GetUsersData()
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                return db.UserRepository.GetAll();
            }
        }
    }
}
