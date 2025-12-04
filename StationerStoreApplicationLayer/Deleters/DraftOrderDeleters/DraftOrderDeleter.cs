using StationeryStoreUILayer.PublicHelpers.DataDeleter.DraftOrderDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataEditors.ProductDataEditors;
using StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.Deleters.DraftOrderDeleters
{
    public class DraftOrderDeleter : IDraftOrderDeleter,
        IDraftOrderDataDeleter,
        IDraftOrderDataGeterById,
        IProductCountEditByDraftOrderDelete
      
    {
        private IDraftOrderDataDeleter _draftOrderDataDeleter;
        private IDraftOrderDataGeterById _draftOrderDataGeterById;
        private IProductCountEditByDraftOrderDelete _productCountEditByDraftOrderDelete;

        public DraftOrderDeleter(
            IDraftOrderDataDeleter draftOrderDataDeleter,
            IDraftOrderDataGeterById draftOrderDataGeterById,
            IProductCountEditByDraftOrderDelete productCountEditByDraftOrderDelete
            )
        {
            _draftOrderDataDeleter = draftOrderDataDeleter;
            _draftOrderDataGeterById = draftOrderDataGeterById;
            _productCountEditByDraftOrderDelete = productCountEditByDraftOrderDelete;
        }

        public void DeleteDrfatOrder(DraftOrdersTable draftOrder)
        {
            DeleteDraftOrderData(draftOrder);
            EditProductCountByDraftOrderDelete(draftOrder.ProductId,draftOrder.RequestedCount);
        }

        public void DeleteDrfatOrder(object draftOrderId)
        {
            var draftOrder = GetDraftOrderDataBtId((int)draftOrderId);
            DeleteDraftOrderData(draftOrder);
            EditProductCountByDraftOrderDelete(draftOrder.ProductId, draftOrder.RequestedCount);

        }
        public void DeleteDraftOrderData(int darftOrderId)
        {
            _draftOrderDataDeleter.DeleteDraftOrderData(darftOrderId);
        }

        public void DeleteDraftOrderData(DraftOrdersTable draftOrder)
        {
            _draftOrderDataDeleter.DeleteDraftOrderData(draftOrder);
        }


        public void EditProductCountByDraftOrderDelete(int ProductId, int RequestedCount)
        {
            _productCountEditByDraftOrderDelete.EditProductCountByDraftOrderDelete(ProductId, RequestedCount);
        }

        public DraftOrdersTable GetDraftOrderDataBtId(object draftOrderId)
        {
            return _draftOrderDataGeterById.GetDraftOrderDataBtId(draftOrderId);
        }
    }
}
