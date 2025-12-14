using StationerStoreApplicationLayer.Searchers.OrderSearchers;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreUILayer.PublicHelpers.DataGeters.OrdersGeters;
using StationeryStoreUILayer.PublicHelpers.DgFillers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.DgOrdersFillingHandlers
{
    public class DgOrdersFillingHandler : IDgOrdersFillingHandler
    {
        private IOrdersDataGeter _ordersDataGeter;
        private IOrderSearcher _orderSearcher;
        private IDgOrdersFiller _dgOrdersFiller;

        public DgOrdersFillingHandler(IOrdersDataGeter ordersDataGeter,
            IOrderSearcher orderSearcher,
            IDgOrdersFiller dgOrdersFiller)
        {
            _ordersDataGeter = ordersDataGeter;
            _orderSearcher = orderSearcher;
            _dgOrdersFiller = dgOrdersFiller;
        }

        public void HandleDgOrdersFilling(DataGridView dataGridView,UserTable userInfo)
        {
            if (userInfo.IsAdmin)
            {
                _dgOrdersFiller.FillDgOrders(dataGridView,_ordersDataGeter.GetOrdersData());
            }
            else
            {
                _dgOrdersFiller.FillDgOrders(dataGridView, _orderSearcher.SearchInOrders(_ordersDataGeter.GetOrdersData(),null,userInfo.UserId));
            }
        }
    }
}
