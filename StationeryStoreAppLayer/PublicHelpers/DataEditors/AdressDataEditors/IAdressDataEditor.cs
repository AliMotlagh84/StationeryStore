using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataEditors.AdressDataEditors
{
    public interface IAdressDataEditor
    {
        void EditAdressData(AdressTable adress);
    }
}
