using StationeryStoreAppLayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.DraftOrderDataEditors;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreAppLayer.PublicHelpers.Editors.ProductEditors;
using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers;
using StationeryStoreAppLayer.PublicHelpers.Searchers.ProductSearchers;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.Editors.DraftOrderEditors
{
    public class DraftOrderEditor : IDraftOrderEditor,
        IProductCountEditorByDraftOrderCountEdit,
        IDraftOrderDataEditor
    {

        private IProductCountEditorByDraftOrderCountEdit _productCountEditorByDraftOrderCountEdit;
        private IDraftOrderDataEditor _draftOrderDataEditor;

        public DraftOrderEditor(
            IProductCountEditorByDraftOrderCountEdit productCountEditorByDraftOrderCountEdit,
            IDraftOrderDataEditor draftOrderDataEditor
            )
        {
            _productCountEditorByDraftOrderCountEdit = productCountEditorByDraftOrderCountEdit;
            _draftOrderDataEditor = draftOrderDataEditor;
        }

        public void EditDraftOrder(DraftOrdersTable draftOrder,int oldRequestedCount)
        {
            EditDraftOrderData(draftOrder);
            EditProductCountByDraftOrderCount(draftOrder.ProductId,draftOrder.RequestedCount,oldRequestedCount);
        }

        public void EditDraftOrderData(DraftOrdersTable draftOrder)
        {
            _draftOrderDataEditor.EditDraftOrderData(draftOrder);
        }

        public void EditProductCountByDraftOrderCount(int ProductId, int newRequestedCount, int oldRequestedCount)
        {
            _productCountEditorByDraftOrderCountEdit.EditProductCountByDraftOrderCount(ProductId, newRequestedCount, oldRequestedCount);
        }
    }
}
