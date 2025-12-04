using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataEditors.DraftOrderDataEditors
{
    public interface IDraftOrderDataEditor
    {
        void EditDraftOrderData(DraftOrdersTable draftOrder);
    }
}
