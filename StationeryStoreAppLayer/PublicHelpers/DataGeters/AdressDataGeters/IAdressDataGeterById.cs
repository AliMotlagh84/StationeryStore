using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataGeters.AdressDataGeters
{
    public interface IAdressDataGeterById
    {
        AdressTable GetAdressDataById(object id);
    }
}
