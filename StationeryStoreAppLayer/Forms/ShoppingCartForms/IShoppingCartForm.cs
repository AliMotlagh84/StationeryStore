using StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.ShoppingCartForms
{
    public interface IShoppingCartForm :
        IDraftOrderDataGeter
    {
        public UserTable UserInfo { get; set; }
    }
}
