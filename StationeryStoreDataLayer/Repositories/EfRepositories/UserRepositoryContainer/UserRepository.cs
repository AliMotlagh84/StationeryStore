using Microsoft.EntityFrameworkCore;
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
    }
}
