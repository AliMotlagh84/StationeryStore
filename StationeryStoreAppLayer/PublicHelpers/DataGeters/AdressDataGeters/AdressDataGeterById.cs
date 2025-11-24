using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataGeters.AdressDataGeters
{
    public class AdressDataGeterById : IAdressDataGeterById
    {
        public AdressTable GetAdressDataById(object id)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                return db.AdressRepository.GetById(id);
            }
        }
    }
}
