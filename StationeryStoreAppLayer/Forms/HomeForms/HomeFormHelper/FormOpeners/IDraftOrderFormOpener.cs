using Microsoft.EntityFrameworkCore.Infrastructure;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.Forms.DraftOrderForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.FormOpeners
{
    public interface IDraftOrderFormOpener
    {
        void OpenDraftOrderForm(ProductsTable productInfo,UserTable OrdererInfo);
    }
}
