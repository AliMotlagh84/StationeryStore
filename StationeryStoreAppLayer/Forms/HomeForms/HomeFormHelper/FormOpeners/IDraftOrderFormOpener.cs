using Microsoft.EntityFrameworkCore.Infrastructure;
using StationeryStoreDataLayer.Models;
using StationeryStoreAppLayer.Forms.DraftOrderForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.FormOpeners
{
    public interface IDraftOrderFormOpener
    {
        void OpenDraftOrderForm(ProductsTable productInfo,UserTable OrdererInfo);
    }
}
