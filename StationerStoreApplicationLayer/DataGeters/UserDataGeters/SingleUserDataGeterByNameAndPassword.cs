using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataGeters.UserDataGeters
{
    public class SingleUserDataGeterByNameAndPassword : ISingleUserDataGeterByNameAndPassword
    {
        public UserTable GetSingleUserDataByNameAndPassword(string username, string password)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
              return  db.UserRepository.GetAll(u => u.UserName==username && u.Password==password).SingleOrDefault();
            }
        }
    }
}
