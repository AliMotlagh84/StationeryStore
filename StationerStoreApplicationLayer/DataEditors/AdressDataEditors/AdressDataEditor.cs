using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataEditors.AdressDataEditors
{
    public class AdressDataEditor : IAdressDataEditor
    {
        public void EditAdressData(AdressTable adress)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.AdressRepository.Update(adress);
                db.Save();
            }
        }
    }
}
