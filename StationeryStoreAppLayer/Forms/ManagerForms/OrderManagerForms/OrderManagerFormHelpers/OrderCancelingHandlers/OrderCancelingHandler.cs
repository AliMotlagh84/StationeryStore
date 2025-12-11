using StationerStoreApplicationLayer.DataDeleter.OrdersDataDeleters;
using StationerStoreApplicationLayer.Searchers.OrderSearchers;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.PublicHelpers.DataGeters.OrdersGeters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.ManagerForms.OrderManagerForms.OrderManagerFormHelpers.OrderCancelingHandlers
{
    public class OrderCancelingHandler : IOrderCancelingHandler,
        IOrdersDataGeter,
        IOrderSearcher,
        IOrderDataDeleter
    {
        private IOrdersDataGeter _ordersDataGeter;
        private IOrderSearcher _orderSearcher;
        private IOrderDataDeleter _orderDataDeleter;

        public OrderCancelingHandler(IOrdersDataGeter ordersDataGeter,
            IOrderSearcher orderSearcher,
            IOrderDataDeleter orderDataDeleter)
        {
            _ordersDataGeter = ordersDataGeter;
            _orderSearcher = orderSearcher;
            _orderDataDeleter = orderDataDeleter;
        }

        public void CancelOrder(int orderId)
        {
            var order = SearchInOrders(GetOrdersData(),orderId).FirstOrDefault();
            if (order.IsDelivered == true) {
                MessageBox.Show("این سفارش تحویل داده شده است", "خطا", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("آیا از لغو این سفارش مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteOrderData(order);
                    MessageBox.Show("سفارش با موفقیت لغو شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void DeleteOrderData(OrdersTable order)
        {
            _orderDataDeleter.DeleteOrderData(order);
        }

        public void DeleteOrderData(object orderId)
        {
           _orderDataDeleter.DeleteOrderData(orderId);
        }

        public List<OrdersTable> GetOrdersData()
        {
            return _ordersDataGeter.GetOrdersData();
        }

        public List<OrdersTable> SearchInOrders(IEnumerable<OrdersTable> orders, int? orderId = null, int? userId = null, string? userName = null, string? minDate = null, string? maxDate = null, long? minAmount = null, long? maxAmount = null, bool? deliveryState = null)
        {
            return _orderSearcher.SearchInOrders(orders,orderId,userId,userName,minDate,maxDate,minAmount,maxAmount,deliveryState);
        }
    }
}
