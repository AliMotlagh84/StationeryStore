using StationerStoreApplicationLayer.DataDeleter.OrdersDataDeleters;
using StationerStoreApplicationLayer.JsonHandlers.JsonRestorers.JsonToDrfatOrderRestorers;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.PublicHelpers.DataEditors.ProductDataEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Deleters.OrderDeleters
{
    public class OrderDeleter : IOrderDeleter,
        IOrderDataDeleter,
        IJsonToDrfatOrderRestorer,
        IProductCountEditByDraftOrderDelete
    {
        private IOrderDataDeleter _orderDataDeleter;
        private IJsonToDrfatOrderRestorer _jsonToDrfatOrderRestorer;
        private IProductCountEditByDraftOrderDelete _productCountEditByDraftOrderDelete;
        public OrderDeleter(IJsonToDrfatOrderRestorer jsonToDrfatOrderRestorer,
            IOrderDataDeleter orderDataDeleter,
            IProductCountEditByDraftOrderDelete productCountEditByDraftOrderDelete)
        {
            _jsonToDrfatOrderRestorer = jsonToDrfatOrderRestorer;
            _orderDataDeleter = orderDataDeleter;
            _productCountEditByDraftOrderDelete = productCountEditByDraftOrderDelete;
        }

        public void DeleteOrder(OrdersTable order)
        {
            if (order.IsDelivered == false)
            {
                var orderInfo = RestorJsonToDraftOrder(order.OrderInfo);
                foreach (var orderInfoItem in orderInfo)
                {
                    EditProductCountByDraftOrderDelete(orderInfoItem.ProductId, orderInfoItem.RequestedCount);
                }
            }
            DeleteOrderData(order);
        }

        public void DeleteOrderData(OrdersTable order)
        {
            _orderDataDeleter.DeleteOrderData(order);
        }

        public void DeleteOrderData(object orderId)
        {
            _orderDataDeleter.DeleteOrderData(orderId);
        }

        public void EditProductCountByDraftOrderDelete(int ProductId, int RequestedCount)
        {
            _productCountEditByDraftOrderDelete.EditProductCountByDraftOrderDelete(ProductId, RequestedCount);
        }

        public List<DraftOrdersTable> RestorJsonToDraftOrder(string JsonString)
        {
            return _jsonToDrfatOrderRestorer.RestorJsonToDraftOrder(JsonString);
        }
    }
}
