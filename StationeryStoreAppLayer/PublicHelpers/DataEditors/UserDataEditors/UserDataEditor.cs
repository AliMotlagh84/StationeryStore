using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataEditors.UserDataEditors
{
    public class UserDataEditor : IUserDataEditor
    {
        public void EditUserData(UserTable userToEdit)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.UserRepository.Update(userToEdit);
                db.Save();
            }
        }
    }
}
