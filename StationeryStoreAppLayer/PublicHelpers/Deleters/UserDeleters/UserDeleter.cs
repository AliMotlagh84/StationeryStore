using Microsoft.VisualBasic.ApplicationServices;
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

namespace StationeryStoreUILayer.PublicHelpers.Deleters.UserDeleters
{
    public class UserDeleter : IUserDeleter,
    IUserDataDeleter,
    IDraftOrderDataGeter,
    IDraftOrderSearcher,
    IDraftOrderDataDeleter
    {
        private IUserDataDeleter _userDataDeleter;
        private IDraftOrderDataGeter _draftOrderDataGeter;
        private IDraftOrderSearcher _draftOrderSearcher;
        private IDraftOrderDataDeleter _draftOrderDataDeleter;
        public UserDeleter(IUserDataDeleter userDataDeleter,
            IDraftOrderDataGeter draftOrderDataGeter,
            IDraftOrderSearcher draftOrderSearcher,
            IDraftOrderDataDeleter draftOrderDataDeleter
            )
        {
            _userDataDeleter = userDataDeleter;
            _draftOrderDataGeter = draftOrderDataGeter;
            _draftOrderSearcher = draftOrderSearcher;
            _draftOrderDataDeleter = draftOrderDataDeleter;
        }
        public void DeleteDraftOrderData(int darftOrderId)
        {
           _draftOrderDataDeleter.DeleteDraftOrderData(darftOrderId);
        }

        public void DeleteDraftOrderData(DraftOrdersTable draftOrder)
        {
            _draftOrderDataDeleter.DeleteDraftOrderData(draftOrder);
        }

        public void DeleteUser(object userId)
        {
            var drfatOrders = SearchInDraftOrders(GetDraftOrderData(), null, (int)userId);
            foreach (var draftOrder in drfatOrders)
            {
                DeleteDraftOrderData(draftOrder.UserId);
            }
            DeleteUserData((int)userId);
        }

        public void DeleteUser(UserTable user)
        {
            var drfatOrders = SearchInDraftOrders(GetDraftOrderData(),null,user.UserId,user.UserName);
            foreach (var draftOrder in drfatOrders)
            {
                DeleteDraftOrderData(draftOrder);
;           }
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
