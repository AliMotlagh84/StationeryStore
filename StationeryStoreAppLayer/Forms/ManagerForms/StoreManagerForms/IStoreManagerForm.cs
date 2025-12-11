using StationeryStoreUILayer.Forms.ManagerForms.StoreManagerForms.StoreMangerHelpers.FormOpeners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.ManagerForms.StoreManagerForms
{
    public interface IStoreManagerForm : 
        IProductsManagerFormOpener,
        IBrandsManagerFormOpener,
        IDraftOrdersManagerFormOpener,
        IUserManagerFormOpener,
        IAdressesManagerFormOpener,
        IOrdersManagerFormOpener
    {
    }
}
