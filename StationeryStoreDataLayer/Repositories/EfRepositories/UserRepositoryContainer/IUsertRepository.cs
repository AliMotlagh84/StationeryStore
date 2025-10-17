using StationaryStoreViewModels.EfViewModels.UserTableViewModels;
using StationeryStore.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreDataLayer.Repositories.EfRepositories.UserRepositoryContainer
{
    public interface IUserRepository :IGenericRepository<UserTable>
    {
        public bool HasUser(LoginUserVM user);
        public bool IsAdmin(LoginUserVM user);
        public bool IsUniqe(SignUpVM user);
    }
}
