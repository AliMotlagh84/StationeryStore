using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Editors.DraftOrderEditors
{
    public interface IDraftOrderEditor
    {
        public void EditDraftOrder(DraftOrdersTable draftOrder, int oldRequestedCount)
;
    }
}
