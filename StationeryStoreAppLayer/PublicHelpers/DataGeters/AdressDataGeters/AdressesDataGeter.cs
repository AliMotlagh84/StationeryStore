using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataGeters.AdressDataGeters
{
    public class AdressesDataGeter : IAdressesDataGeter
    {
        public List<AdressTable> GetAdressesData()
        {
            using(EfUnitOfWork db =  new EfUnitOfWork())
            {
                return db.AdressRepository.GetAll();
            }
        }
    }
}
