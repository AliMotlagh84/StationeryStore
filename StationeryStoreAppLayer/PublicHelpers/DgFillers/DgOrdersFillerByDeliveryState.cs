using StationaryStoreUtility.Convertores.DateConvertors;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DgFillers
{
    public class DgOrdersFillerByDeliveryState : IDgOrdersFiller,IMiladiToOtherDateConvertor
    {
        private IMiladiToOtherDateConvertor _toShamsiConvertor;

        public DgOrdersFillerByDeliveryState(IMiladiToOtherDateConvertor toShamsiConvertor)
        {
            _toShamsiConvertor = toShamsiConvertor;
        }
        public string ConvertAsMiladi(DateTime date)
        {
           return _toShamsiConvertor.ConvertAsMiladi(date);
        }

        public void FillDgOrders(DataGridView dg, Func<List<OrdersTable>> dataGeterMethod)
        {
            string deliveryState;
            foreach (var order in dataGeterMethod())
            {
                if (order.IsDelivered == true)
                    deliveryState = "تحویل داده شده";
                else
                    deliveryState = "در انتظار";
                
                dg.Rows.Add(order.UserId, order.UserId, order.UserName, order.Amount,ConvertAsMiladi(order.Date), "کلیک کنید",deliveryState);
            }
        }

    }
}
