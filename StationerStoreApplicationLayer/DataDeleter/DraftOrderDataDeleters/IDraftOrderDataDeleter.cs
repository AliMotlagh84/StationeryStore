using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataDeleter.DraftOrderDataDeleters
{
    public interface IDraftOrderDataDeleter
    {
        void DeleteDraftOrderData(int darftOrderId);
        void DeleteDraftOrderData(DraftOrdersTable draftOrder);
    }
}
