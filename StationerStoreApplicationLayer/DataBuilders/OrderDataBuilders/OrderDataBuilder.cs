using StationerStoreApplicationLayer.JsonHandlers.JsonBuilders.DraftOrdersJsonBuilder;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.DataBuilders.OrderDataBuilders
{
    public class OrderDataBuilder : IOrderDataBuilder
    {
        public OrdersTable BuildOrderData(int userId, string userName, DateTime orderSendDate, long amount, string orderInfoStringJson, bool IsDeliverd, int? OrderId = null)
        {
            var Order = new OrdersTable()
            {
                UserId = userId,
                UserName = userName,
                Date = orderSendDate,
                Amount = amount,
                OrderInfo = orderInfoStringJson,
                IsDelivered = IsDeliverd,
            };
            if (OrderId != null)
            {
                Order.OrderId = (int)OrderId;
            }
            return Order;
        }

    }
}
