using StationerStoreApplicationLayer.DataAdders.OrderDataAdders;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.DraftOrderDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Adders.OrderAdders
{
    public class OrderAdder : IOrderAdder ,
        IOrderDataAdder,
        IDraftOrderDataGeter,
        IDraftOrderSearcher,
        IDraftOrderDataDeleter
    {
        private IOrderDataAdder _orderDataAdder;
        private IDraftOrderDataGeter _draftOrderDataGeter;
        private IDraftOrderSearcher _draftOrderSearcher;
        private IDraftOrderDataDeleter _draftOrderDataDeleter;

        public OrderAdder(IOrderDataAdder orderDataAdder,
            IDraftOrderDataGeter draftOrderDataGeter,
            IDraftOrderSearcher draftOrderSearcher,
            IDraftOrderDataDeleter draftOrderDataDeleter)
        {
            _orderDataAdder = orderDataAdder;
            _draftOrderDataGeter = draftOrderDataGeter;
            _draftOrderSearcher = draftOrderSearcher;
            _draftOrderDataDeleter = draftOrderDataDeleter;
        }

        public void AddOrder(OrdersTable order)
        {
            var DraftOrders = SearchInDraftOrders(GetDraftOrderData(),null,order.UserId);
            AddOrderData(order);
            foreach (var DraftOrder in DraftOrders)
            {
                DeleteDraftOrderData(DraftOrder);
            }
        }

        public void AddOrderData(OrdersTable newOrders)
        {
            _orderDataAdder.AddOrderData(newOrders);
        }

        public void DeleteDraftOrderData(int darftOrderId)
        {
            _draftOrderDataDeleter.DeleteDraftOrderData(darftOrderId);
        }

        public void DeleteDraftOrderData(DraftOrdersTable draftOrder)
        {
            _draftOrderDataDeleter.DeleteDraftOrderData(draftOrder);
        }

        public List<DraftOrdersTable> GetDraftOrderData()
        {
            return _draftOrderDataGeter.GetDraftOrderData();
        }

        public List<DraftOrdersTable> SearchInDraftOrders(IEnumerable<DraftOrdersTable> draftOrders, int? id = null, int? userId = null, string? userName = null, int? prductId = null, string? productName = null, int? brandId = null, string? brandName = null, int? minRequestedCount = null, int? maxRequestedCount = null, long? minAmount = null, long? maxAmount = null, long? minTotalAmount = null, long? maxTotalAmount = null)
        {
            return _draftOrderSearcher.SearchInDraftOrders(draftOrders,id,userId,userName,prductId,productName,brandId,brandName,minRequestedCount,maxRequestedCount,minAmount,maxAmount,minTotalAmount,maxTotalAmount);
        }
    }
}
