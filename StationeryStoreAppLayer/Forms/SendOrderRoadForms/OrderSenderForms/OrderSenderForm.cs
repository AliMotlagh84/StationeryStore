using Microsoft.Identity.Client;
using StationaryStoreUtility.Convertores.DateConvertors;
using StationerStoreApplicationLayer.Adders.OrderAdders;
using StationerStoreApplicationLayer.DataBuilders.OrderDataBuilders;
using StationerStoreApplicationLayer.JsonHandlers.JsonBuilders.DraftOrdersJsonBuilder;
using StationerStoreApplicationLayer.JsonHandlers.JsonRestorers.JsonToDrfatOrderRestorers;
using StationerStoreApplicationLayer.Searchers.OrderSearchers;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.OrdersGeters;
using StationeryStoreUILayer.PublicHelpers.DgFillers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreUILayer.Forms.SendOrderRoadForms.OrderSenderForms
{
    public partial class OrderSenderForm : Form, IOrderSenderForm,
        IOrderAdder,
        IOrderDataBuilder,
        IOrdersDataGeter,
        IOrderSearcher,
        IDraftOrdersJsonBuilder,
        IJsonToDrfatOrderRestorer,
        IDraftOrderDataGeter,
        IDraftOrderSearcher,
        IMiladiToOtherDateConvertor,
        IDgFiller
        
    {
        private UserTable userInfo;
        private long orderTotalAmount;
        private IOrderAdder _orderAdder;
        private IOrderDataBuilder _orderDataBuilder;
        private IOrdersDataGeter _ordersDataGeter; 
        private IOrderSearcher _orderSearcher;
        private IDraftOrdersJsonBuilder _draftOrdersJsonBuilder;
        private IJsonToDrfatOrderRestorer _jsonToDraftOrderRestartor;
        private IDraftOrderDataGeter _draftOrderDataGeter;
        private IDraftOrderSearcher _draftOrderSearcher;
        private IMiladiToOtherDateConvertor _miladiToOtherDateConvertor;
        private IDgFiller _dgFiller;
        UserTable IOrderSenderForm.UserInfo { get => userInfo; set => userInfo = value; }
        long IOrderSenderForm.OrderTotalAmount { get => orderTotalAmount; set => orderTotalAmount = value; }

        public OrderSenderForm(IOrderAdder orderAdder,
            IOrderDataBuilder orderDataBuilder,
            IDraftOrdersJsonBuilder draftOrdersJsonBuilder,
            IDraftOrderDataGeter draftOrderDataGeter,
            IDraftOrderSearcher draftOrderSearcher,
            IMiladiToOtherDateConvertor miladiToOtherDateConvertor,
            IDgFiller dgFiller,
            IJsonToDrfatOrderRestorer jsonToDraftOrderRestartor,
            IOrdersDataGeter ordersDataGeter,
            IOrderSearcher orderSearcher)
        {
            InitializeComponent();
            _orderAdder = orderAdder;
            _orderDataBuilder = orderDataBuilder;
            _draftOrdersJsonBuilder = draftOrdersJsonBuilder;
            _draftOrderDataGeter = draftOrderDataGeter;
            _draftOrderSearcher = draftOrderSearcher;
            _miladiToOtherDateConvertor = miladiToOtherDateConvertor;
            _dgFiller = dgFiller;
            _jsonToDraftOrderRestartor = jsonToDraftOrderRestartor;
            _ordersDataGeter = ordersDataGeter;
            _orderSearcher = orderSearcher;

        }

        private void OrderSenderForm_Load(object sender, EventArgs e)
        {
            OrderAddHandle();
            RefreshForm();
        }

        private void RefreshForm()
        {
            OrderDateLbl.Text = ConvertAsMiladi(DateTime.Now);
            CompleteOrderDateLbl.Text = ConvertAsMiladi(DateTime.Now.AddDays(5));
            OrderNameLbl.Text = userInfo.UserName;
            FillDg(DraftOrdersDG,RestorJsonToDraftOrder(SearchInOrders(GetOrdersData(),null,userInfo.UserId).Last().OrderInfo));
        }

        private void OrderAddHandle()
        {
            var drfatOrders = SearchInDraftOrders(GetDraftOrderData(), null, userInfo.UserId);
            var orderInfoJsonString = GetDraftOrdersJson(drfatOrders);
            var order = BuildOrderData(userInfo.UserId, userInfo.UserName, DateTime.Now, orderTotalAmount, orderInfoJsonString, false);
            AddOrder(order);
        }
        

        private void GoHomeFormBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public void AddOrder(OrdersTable order)
        {
            _orderAdder.AddOrder(order);
        }

        public OrdersTable BuildOrderData(int userId, string userName, DateTime orderSendDate, long amount, string orderInfoStringJson, bool IsDeliverd, int? OrderId = null)
        {
            return _orderDataBuilder.BuildOrderData(userId, userName, orderSendDate, amount, orderInfoStringJson, IsDeliverd, OrderId);
        }

        public string GetDraftOrdersJson(List<DraftOrdersTable> draftOrders)
        {
            return _draftOrdersJsonBuilder.GetDraftOrdersJson(draftOrders);
        }

        public List<DraftOrdersTable> GetDraftOrderData()
        {
            return _draftOrderDataGeter.GetDraftOrderData();
        }

        public List<DraftOrdersTable> SearchInDraftOrders(IEnumerable<DraftOrdersTable> draftOrders, int? id = null, int? userId = null, string? userName = null, int? prductId = null, string? productName = null, int? brandId = null, string? brandName = null, int? minRequestedCount = null, int? maxRequestedCount = null, long? minAmount = null, long? maxAmount = null, long? minTotalAmount = null, long? maxTotalAmount = null)
        {
            return _draftOrderSearcher.SearchInDraftOrders(draftOrders, id, userId, userName, prductId, productName, brandId, brandName, minRequestedCount, maxRequestedCount, minAmount, maxAmount, minTotalAmount, maxTotalAmount);
        }

        public string ConvertAsMiladi(DateTime date)
        {
            return _miladiToOtherDateConvertor.ConvertAsMiladi(date);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void FillDg<T>(DataGridView dg, List<T> data)
        {
            _dgFiller.FillDg(dg, data);
        }

        public List<OrdersTable> GetOrdersData()
        {
            return _ordersDataGeter.GetOrdersData();
        }

        public List<OrdersTable> SearchInOrders(IEnumerable<OrdersTable> orders, int? orderId = null, int? userId = null, string? userName = null, DateTime? minDate = null, DateTime? maxDate = null, long? minAmount = null, long? maxAmount = null, bool? deliveryState = null)
        {
           return _orderSearcher.SearchInOrders(orders, orderId, userId, userName, minDate, maxDate, minAmount, maxAmount, deliveryState);
        }

        public List<DraftOrdersTable> RestorJsonToDraftOrder(string JsonString)
        {
            return _jsonToDraftOrderRestartor.RestorJsonToDraftOrder(JsonString);
        }
    }
}
