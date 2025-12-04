using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataDeleter.AdressDataDeleters
{
    public class AdressDataDeleter : IAdressDataDeleter
    {
        public void DeleteAdressData(object id)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.AdressRepository.Delete(id);
                db.Save();
            }
        }

        public void DeleteAdressData(AdressTable adress)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.AdressRepository.Delete(adress);
                db.Save();
            }
        }
    }
}
