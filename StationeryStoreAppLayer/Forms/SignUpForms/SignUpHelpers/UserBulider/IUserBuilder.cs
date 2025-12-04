using Microsoft.VisualBasic.ApplicationServices;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.SignUpForms.SignUpHelpers.UserBulider
{
    public interface IUserBuilder
    {
        UserTable BuildUser(string username, string password,string? email,bool isAdmin);
    }
}
