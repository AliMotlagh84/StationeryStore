using StationeryStoreUILayer.PublicHelpers.DataDeleter.DraftOrderDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.UserDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.AdressDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.AdressDataGeters;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers;
using StationerStoreApplicationLayer.Deleters.DraftOrderDeleters;
using StationerStoreApplicationLayer.Searchers.OrderSearchers;
using StationeryStoreUILayer.PublicHelpers.DataGeters.OrdersGeters;
using StationerStoreApplicationLayer.Deleters.OrderDeleters;

namespace StationerStoreApplicationLayer.Deleters.UserDeleters
{
    public class UserDeleter : IUserDeleter,
    IUserDataDeleter,
    IDraftOrderDataGeter,
    IDraftOrderSearcher,
    IDraftOrderDeleter,
    IAdressesDataGeter,
    IAdressSearcher,
    IAdressDataDeleter,
    IOrdersDataGeter,
    IOrderSearcher,
    IOrderDeleter
    {
        private IUserDataDeleter _userDataDeleter;
        private IDraftOrderDataGeter _draftOrderDataGeter;
        private IDraftOrderSearcher _draftOrderSearcher;
        private IDraftOrderDeleter _draftOrderDeleter;
        private IAdressesDataGeter _adressesDataGeter;
        private IAdressSearcher _adressSearchers;   
        private IAdressDataDeleter _adressDataDeleter;
        private IOrdersDataGeter _ordersDataGeter;
        private IOrderSearcher _orderSearcher;  
        private IOrderDeleter _orderDeleter;
        public UserDeleter(IUserDataDeleter userDataDeleter,
            IDraftOrderDataGeter draftOrderDataGeter,
            IDraftOrderSearcher draftOrderSearcher,
            IDraftOrderDeleter draftOrderDeleter,
            IAdressesDataGeter adressesDataGeter,
            IAdressSearcher adressSearcher,
            IAdressDataDeleter adressDataDeleter,
            IOrdersDataGeter ordersDataGeter,
            IOrderSearcher orderSearcher,
            IOrderDeleter orderDeleter
            )
        {
            _userDataDeleter = userDataDeleter;
            _draftOrderDataGeter = draftOrderDataGeter;
            _draftOrderSearcher = draftOrderSearcher;
            _draftOrderDeleter = draftOrderDeleter;
            _adressesDataGeter = adressesDataGeter;
            _adressSearchers = adressSearcher;
            _adressDataDeleter = adressDataDeleter;
            _ordersDataGeter = ordersDataGeter;
            _orderSearcher = orderSearcher;
            _orderDeleter = orderDeleter;
        }

        public void DeleteAdressData(object id)
        {
            _adressDataDeleter.DeleteAdressData(id);
        }

        public void DeleteAdressData(AdressTable adress)
        {
            _adressDataDeleter.DeleteAdressData(adress);

        }

        public void DeleteDrfatOrder(DraftOrdersTable draftOrder)
        {
            _draftOrderDeleter.DeleteDrfatOrder(draftOrder);
        }

        public void DeleteDrfatOrder(object draftOrderId)
        {
            _draftOrderDeleter.DeleteDrfatOrder(draftOrderId);
        }

        public void DeleteOrder(OrdersTable order)
        {
            _orderDeleter.DeleteOrder(order);
        }

        public void DeleteUser(object userId)
        {
            var drfatOrders = SearchInDraftOrders(GetDraftOrderData(), null, (int)userId);
            foreach (var draftOrder in drfatOrders)
            {
                DeleteDrfatOrder(draftOrder);
            }
            var adresses = SearchInAdresses(GetAdressesData(),null,(int)userId);
            foreach (var adress in adresses)
            {
                DeleteAdressData(adress);
            }
            var orders = SearchInOrders(GetOrdersData(), null,(int)userId); 
            foreach (var order in orders)
            {
                DeleteOrder(order);
            }
            DeleteUserData((int)userId);
        }

        public void DeleteUser(UserTable user)
        {
            var drfatOrders = SearchInDraftOrders(GetDraftOrderData(),null,user.UserId,user.UserName);
            foreach (var draftOrder in drfatOrders)
            {
                DeleteDrfatOrder(draftOrder);
            }
            var adresses = SearchInAdresses(GetAdressesData(), null, user.UserId,user.UserName);
            foreach (var adress in adresses)
            {
                DeleteAdressData(adress.AdressId);
            }
            var orders = SearchInOrders(GetOrdersData(), null, user.UserId,user.UserName);
            foreach (var order in orders)
            {
                DeleteOrder(order);
            }
            DeleteUserData(user);
        }

        public void DeleteUserData(object userId)
        {
            _userDataDeleter.DeleteUserData(userId);
        }

        public void DeleteUserData(UserTable user)
        {
            _userDataDeleter.DeleteUserData(user);

        }

        public List<AdressTable> GetAdressesData()
        {
            return _adressesDataGeter.GetAdressesData();
        }

        public List<DraftOrdersTable> GetDraftOrderData()
        {
            return _draftOrderDataGeter.GetDraftOrderData();
        }

        public List<OrdersTable> GetOrdersData()
        {
            return _ordersDataGeter.GetOrdersData();
        }

        public List<AdressTable> SearchInAdresses(IEnumerable<AdressTable> adresses, object? adressId = null, object? userId = null, string? userName = null, string? city = null, string? street = null, string? alley = null, string? houseNumber = null, long? postalCode = null)
        {
            return _adressSearchers.SearchInAdresses(adresses,adressId,userId,userName,city,street,alley,houseNumber,postalCode);
        }

        public List<DraftOrdersTable> SearchInDraftOrders(IEnumerable<DraftOrdersTable> draftOrders, int? id = null, int? userId = null, string? userName = null, int? prductId = null, string? productName = null, int? brandId = null, string? brandName = null, int? minRequestedCount = null, int? maxRequestedCount = null, long? minAmount = null, long? maxAmount = null, long? minTotalAmount = null, long? maxTotalAmount = null)
        {
            return _draftOrderSearcher.SearchInDraftOrders(draftOrders,id,userId,userName,prductId,productName,brandId,brandName,minRequestedCount,maxRequestedCount,minAmount,maxAmount,minTotalAmount,maxTotalAmount);
        }

        public List<OrdersTable> SearchInOrders(IEnumerable<OrdersTable> orders, int? orderId = null, int? userId = null, string? userName = null, string? minDate = null, string? maxDate = null, long? minAmount = null, long? maxAmount = null, bool? deliveryState = null)
        {
            return _orderSearcher.SearchInOrders(orders,orderId,userId,userName,minDate,maxDate,minAmount,maxAmount,deliveryState);
        }
    }
}
