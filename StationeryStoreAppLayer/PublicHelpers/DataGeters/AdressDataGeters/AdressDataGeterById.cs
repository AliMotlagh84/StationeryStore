using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataGeters.AdressDataGeters
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
