using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataEditors.AdressDataEditors
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
