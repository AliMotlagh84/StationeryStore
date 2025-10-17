using Microsoft.VisualBasic.ApplicationServices;
using StationeryStore.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.SignUpForms.SignUpHelpers.UserAdder
{
    public interface IUserBuilder
    {
        UserTable BuildUser(string username, string password,string? email,bool isAdmin);
    }
}
