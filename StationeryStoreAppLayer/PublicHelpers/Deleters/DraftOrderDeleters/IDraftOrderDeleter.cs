using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Deleters.DraftOrderDeleters
{
    public interface IDraftOrderDeleter
    {
        void DeleteDrfatOrder(DraftOrdersTable draftOrder);
        void DeleteDrfatOrder(object draftOrderId);
    }
}
