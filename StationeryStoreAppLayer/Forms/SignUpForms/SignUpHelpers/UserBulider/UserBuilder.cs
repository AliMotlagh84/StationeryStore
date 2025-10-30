using Microsoft.VisualBasic.ApplicationServices;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SignUpForms.SignUpHelpers.UserBulider
{
    public class UserBuilder : IUserBuilder
    {
        public UserTable BuildUser(string username, string password, string? email, bool isAdmin)
        {
            return new UserTable() { UserName=username , Password = password , Email = email , IsAdmin = isAdmin};
        }
    }
}
