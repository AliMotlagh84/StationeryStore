using StationeryStoreUILayer.PublicHelpers.DataBuilders.ProductDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataEditors.DraftOrderDataEditors;
using StationeryStoreUILayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreUILayer.PublicHelpers.Editors.ProductEditors;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.ProductSearchers;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Editors.DraftOrderEditors
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
