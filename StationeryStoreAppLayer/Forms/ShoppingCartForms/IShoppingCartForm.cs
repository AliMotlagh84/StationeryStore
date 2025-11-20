using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ShoppingCartForms
{
    public interface IShoppingCartForm
    {
        public UserTable UserInfo { get; set; }
    }
}
