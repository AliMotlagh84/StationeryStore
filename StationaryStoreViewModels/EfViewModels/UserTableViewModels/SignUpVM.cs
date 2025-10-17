using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryStoreViewModels.EfViewModels.UserTableViewModels
{
    public class SignUpVM
    {
        public SignUpVM(string username, string password ,string email)
        {
            UserName = username;
            Password = password;
            Email = email;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
