using StationerStoreApplicationLayer.DataEditors.OrderDataEditor;
using StationerStoreApplicationLayer.Deleters.OrderDeleters;
using StationerStoreApplicationLayer.JsonHandlers.JsonRestorers.JsonToDrfatOrderRestorers;
using StationerStoreApplicationLayer.Searchers.OrderSearchers;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.PublicHelpers.DataEditors.AdressDataEditors;
using StationeryStoreUILayer.PublicHelpers.DataEditors.DraftOrderDataEditors;
using StationeryStoreUILayer.PublicHelpers.DataEditors.UserDataEditors;
using StationeryStoreUILayer.PublicHelpers.DataGeters.AdressDataGeters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.OrdersGeters;
using StationeryStoreUILayer.PublicHelpers.Editors.DraftOrderEditors;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Editors.UserEditors
{
    public class UserEditor : IUserEditor,
        IUserDataEditor,
        IOrdersDataGeter,
        IOrderSearcher,
        IOrderDataEditor,
        IDraftOrderDataGeter,
        IDraftOrderSearcher,
        IDraftOrderDataEditor,
        IAdressesDataGeter,
        IAdressSearcher,
        IAdressDataEditor
    {
        private IUserDataEditor _userDataEditor;
        private IOrdersDataGeter _ordersDataGeter;
        private IOrderSearcher _orderSearcher;
        private IOrderDataEditor _orderDataEditor;
        private IDraftOrderDataGeter _draftOrdersDataGeter;
        private IDraftOrderSearcher _draftOrderSearcher;    
        private IDraftOrderDataEditor _draftOrderDataEditor;
        private IAdressesDataGeter _adressesDataGeter;
        private IAdressSearcher _adressSearcher; 
        private IAdressDataEditor _adressDataEditor;

        public UserEditor(IUserDataEditor userDataEditor,
            IOrdersDataGeter ordersDataGeter,
            IOrderSearcher orderSearcher,
            IOrderDataEditor orderDataEditor,
            IDraftOrderDataGeter draftOrdersDataGeter,
            IDraftOrderSearcher draftOrderSearcher,
            IDraftOrderDataEditor draftOrderDataEditor,
            IAdressesDataGeter adressesDataGeter,
            IAdressSearcher adressSearcher,
            IAdressDataEditor adressDataEditor)
        {
            _userDataEditor = userDataEditor;
            _ordersDataGeter = ordersDataGeter;
            _orderSearcher = orderSearcher;
            _orderDataEditor = orderDataEditor;
            _draftOrdersDataGeter = draftOrdersDataGeter;
            _draftOrderSearcher = draftOrderSearcher;
            _draftOrderDataEditor = draftOrderDataEditor;
            _adressesDataGeter = adressesDataGeter;
            _adressSearcher = adressSearcher;
            _adressDataEditor = adressDataEditor;
        }

        public void EditAdressData(AdressTable adress)
        {
            _adressDataEditor.EditAdressData(adress);
        }

        public void EditDraftOrderData(DraftOrdersTable draftOrder)
        {
            _draftOrderDataEditor.EditDraftOrderData(draftOrder);
        }

        public void EditOrderData(OrdersTable order)
        {
            _orderDataEditor.EditOrderData(order);
        }

        public void EditUser(UserTable userInfo)
        {
            var draftOrders = SearchInDraftOrders(GetDraftOrderData(),null,userInfo.UserId);
            foreach (var draftOrder in draftOrders)
            {
                draftOrder.UserName = userInfo.UserName;
                EditDraftOrderData(draftOrder);
            }
            var orders = SearchInOrders(GetOrdersData(),null,userInfo.UserId);
            foreach(var order in orders)
            {
                order.UserName = userInfo.UserName;
                EditOrderData(order);
            }
            var adresses = SearchInAdresses(GetAdressesData(),null,userInfo.UserId);
            foreach(var adress in adresses)
            {
                adress.UserName = userInfo.UserName;
                EditAdressData(adress);
            }
            EditUserData(userInfo);

        }

        public void EditUserData(UserTable userToEdit)
        {
            _userDataEditor.EditUserData(userToEdit);
        }

        public List<AdressTable> GetAdressesData()
        {
            return _adressesDataGeter.GetAdressesData();
        }

        public List<DraftOrdersTable> GetDraftOrderData()
        {
            return _draftOrdersDataGeter.GetDraftOrderData();
        }

        public List<OrdersTable> GetOrdersData()
        {
            return _ordersDataGeter.GetOrdersData();
        }

        public List<AdressTable> SearchInAdresses(IEnumerable<AdressTable> adresses, object? adressId = null, object? userId = null, string? userName = null, string? city = null, string? street = null, string? alley = null, string? houseNumber = null, long? postalCode = null)
        {
            return _adressSearcher.SearchInAdresses(adresses,adressId,userId,userName,city,street,alley,houseNumber,postalCode);
        }

        public List<DraftOrdersTable> SearchInDraftOrders(IEnumerable<DraftOrdersTable> draftOrders, int? id = null, int? userId = null, string? userName = null, int? prductId = null, string? productName = null, int? brandId = null, string? brandName = null, int? minRequestedCount = null, int? maxRequestedCount = null, long? minAmount = null, long? maxAmount = null, long? minTotalAmount = null, long? maxTotalAmount = null)
        {
            return _draftOrderSearcher.SearchInDraftOrders(draftOrders, id, userId, userName, prductId, productName, brandId, brandName, minRequestedCount, maxRequestedCount, minAmount, maxAmount, minTotalAmount, maxTotalAmount);
        }

        public List<OrdersTable> SearchInOrders(IEnumerable<OrdersTable> orders, int? orderId = null, int? userId = null, string? userName = null, string? minDate = null, string? maxDate = null, long? minAmount = null, long? maxAmount = null, bool? deliveryState = null)
        {
            return _orderSearcher.SearchInOrders(orders, orderId, userId, userName, minDate, maxDate, minAmount, maxAmount, deliveryState);
        }
    }
}
