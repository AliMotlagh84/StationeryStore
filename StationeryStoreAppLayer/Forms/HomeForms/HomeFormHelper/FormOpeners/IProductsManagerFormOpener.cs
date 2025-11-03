using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.FormOpeners
{
    public interface IProductsManagerFormOpener
    {
        void OpenProductsManagerForm(Form? senderFormToHide = null);
    }
}
