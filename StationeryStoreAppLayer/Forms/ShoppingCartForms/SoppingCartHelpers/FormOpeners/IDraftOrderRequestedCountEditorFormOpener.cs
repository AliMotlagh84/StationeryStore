using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.ShoppingCartForms.SoppingCartHelpers.FormOpeners
{
    public interface IDraftOrderRequestedCountEditorFormOpener
    {
        void OpenDraftOrderRequestedCountEditor(DraftOrdersTable draftOrderInfo);
    }
}
