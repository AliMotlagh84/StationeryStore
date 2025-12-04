using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataGeters.UserDataGeters
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
