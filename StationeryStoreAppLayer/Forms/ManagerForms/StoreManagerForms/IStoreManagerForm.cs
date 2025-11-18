using StationeryStoreAppLayer.Forms.ManagerForms.StoreManagerForms.StoreMangerHelpers.FormOpeners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ManagerForms.StoreManagerForms
{
    public interface IStoreManagerForm : 
        IProductsManagerFormOpener,
        IBrandsManagerFormOpener,
        IDraftOrdersManagerFormOpener,
        IUserManagerFormOpener
    {
    }
}
