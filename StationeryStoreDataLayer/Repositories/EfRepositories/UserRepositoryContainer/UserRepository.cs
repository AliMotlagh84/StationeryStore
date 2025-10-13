using Microsoft.EntityFrameworkCore;
using StationaryStoreViewModels.EfViewModels.UserTableViewModels;
using StationeryStore.DataLayer.Models;
using StationeryStoreDataLayer.Repositories.EfRepositories.GenericRepositoryContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreDataLayer.Repositories.EfRepositories.UserRepositoryContainer
{
    public class UserRepository : EfGenericRepository<UserTable>, IUserRepository
    {
        public UserRepository(DbContext db) : base(db)
        {

        }

        public bool HasUser(LoginUserVM user)
        {
           return dbSet.Any(u =>u.UserName == user.UserName && u.Password == user.Password);
        }

        public bool IsAdmin(LoginUserVM user)
        {
            var User = dbSet.FirstOrDefault(u => u.UserName == user.UserName && u.Password == user.Password);
            if(User == null) return false;
            else  return User.IsAdmin;

        }
    }
}
