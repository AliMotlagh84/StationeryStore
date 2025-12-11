using StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByAmount;
using StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByDeliveryState;
using StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByOrderDate;
using StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByOrderId;
using StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByUserId;
using StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByUserName;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Searchers.OrderSearchers
{
    public class OrderSearcher : IOrderSearcher,
        IOrderSearcherByOrderId,
        IOrderSearcherByUserId,
        IOrderSearcherByUserName,
        IOrderSearcherByOrderDate,
        IOrderSearcherByAmount,
        IOrderSearcherByDeliveryState

    {
        private IOrderSearcherByOrderId _orderSearcherByOrderId;
        private IOrderSearcherByUserId _orderSearcherByUserId;
        private IOrderSearcherByUserName _orderSearcherByUserName;
        private IOrderSearcherByOrderDate _orderSearcherByOrderDate;
        private IOrderSearcherByAmount _orderSearcherByAmount;
        private IOrderSearcherByDeliveryState _orderSearcherByDeliveryState;

        public OrderSearcher(IOrderSearcherByOrderId orderSearcherByOrderId, IOrderSearcherByUserId orderSearcherByUserId, IOrderSearcherByUserName orderSearcherByUserName, IOrderSearcherByOrderDate orderSearcherByOrderDate, IOrderSearcherByAmount orderSearcherByAmount, IOrderSearcherByDeliveryState orderSearcherByDeliveryState)
        {
            _orderSearcherByOrderId = orderSearcherByOrderId;
            _orderSearcherByUserId = orderSearcherByUserId;
            _orderSearcherByUserName = orderSearcherByUserName;
            _orderSearcherByOrderDate = orderSearcherByOrderDate;
            _orderSearcherByAmount = orderSearcherByAmount;
            _orderSearcherByDeliveryState = orderSearcherByDeliveryState;
        }

        public List<OrdersTable> SearchInOrders(IEnumerable<OrdersTable> orders, int? orderId = null, int? userId = null, string? userName = null, string? minDate = null, string? maxDate = null, long? minAmount = null, long? maxAmount = null, bool? deliveryState = null)
        {
            var UserIdFiltered = SearchInOrdersByUserId(orders,userId);
            var UserNameFiltered = SearchInOrdersByUserName(UserIdFiltered,userName);
            var AmountFiltered = SearchInOrdersByAmount(UserNameFiltered, minAmount, maxAmount);
            var DateFiltered = SearchInOrdersByOrderDate(AmountFiltered, minDate, maxDate);
            var DelevieryStateFiltered = SearchInOrdersByDeleveryState(DateFiltered, deliveryState);
            var Filtered = SearchInOrdersByOrderId(DelevieryStateFiltered, orderId);
            return Filtered.ToList();
        }

        public IEnumerable<OrdersTable> SearchInOrdersByAmount(IEnumerable<OrdersTable> orders, long? minAmount = null, long? maxAmount = null)
        {
            return _orderSearcherByAmount.SearchInOrdersByAmount(orders, minAmount, maxAmount);
        }

        public IEnumerable<OrdersTable> SearchInOrdersByDeleveryState(IEnumerable<OrdersTable> orders, bool? deliveryState = null)
        {
            return _orderSearcherByDeliveryState.SearchInOrdersByDeleveryState(orders,deliveryState);
        }

        public IEnumerable<OrdersTable> SearchInOrdersByOrderDate(IEnumerable<OrdersTable> orders, string? minDate = null, string? maxDate = null)
        {
            return _orderSearcherByOrderDate.SearchInOrdersByOrderDate(orders,minDate,maxDate);
        }

        public IEnumerable<OrdersTable> SearchInOrdersByOrderId(IEnumerable<OrdersTable> orders, int? orderId = null)
        {
            return _orderSearcherByOrderId.SearchInOrdersByOrderId(orders,orderId);
        }

        public IEnumerable<OrdersTable> SearchInOrdersByUserId(IEnumerable<OrdersTable> orders, int? userId = null)
        {
            return _orderSearcherByUserId.SearchInOrdersByUserId(orders,userId);
        }

        public IEnumerable<OrdersTable> SearchInOrdersByUserName(IEnumerable<OrdersTable> orders, string userName)
        {
            return _orderSearcherByUserName.SearchInOrdersByUserName(orders,userName);
        }
    }
}
