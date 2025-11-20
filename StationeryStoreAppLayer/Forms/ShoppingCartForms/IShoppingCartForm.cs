using StationeryStoreAppLayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ShoppingCartForms
{
    public interface IShoppingCartForm :
        IDraftOrderDataGeter
    {
        public UserTable UserInfo { get; set; }
    }
}
