using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataAdders.AdressDataAdders
{
    public class AdressDataAdder : IAdressDataAdder
    {
        public void AddAdressData(AdressTable adress)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.AdressRepository.Add(adress);
                db.Save();
            }
        }


    }
}
