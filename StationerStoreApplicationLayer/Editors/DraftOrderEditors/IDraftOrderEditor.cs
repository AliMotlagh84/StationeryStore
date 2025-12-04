using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Editors.DraftOrderEditors
{
    public interface IDraftOrderEditor
    {
        public void EditDraftOrder(DraftOrdersTable draftOrder, int oldRequestedCount)
;
    }
}
