using StationaryStoreUtility.Convertores.DateConvertors;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DgFillers
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

        public void FillDgOrders(DataGridView dg,List<OrdersTable> orderData)
        {
            dg.Rows.Clear();
            string deliveryState;
            foreach (var order in orderData)
            {
                if (order.IsDelivered == true)
                    deliveryState = "تحویل داده شده";
                else
                    deliveryState = "در انتظار";
                
                dg.Rows.Add(order.OrderId, order.UserId, order.UserName, order.Amount,ConvertAsMiladi(order.Date), "کلیک کنید",deliveryState);
            }
        }

    }
}
