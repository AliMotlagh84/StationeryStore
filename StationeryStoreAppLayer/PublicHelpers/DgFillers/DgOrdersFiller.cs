using StationaryStoreUtility.Convertores.DateConvertors;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DgFillers
{
    public class DgOrdersFiller : IDgOrdersFiller
    {
        IMiladiToOtherDateConvertor ToShamsiConvertor = new MiladiToPersianDateConvertor();
        public void FillDgOrders(DataGridView dg, List<OrdersTable> ordersData)
        {
            dg.Rows.Clear();
            foreach (var order in ordersData)
            {
                dg.Rows.Add(order.OrderId,order.UserId,order.UserName,order.Amount,ToShamsiConvertor.ConvertAsMiladi(order.Date),"کلیک کنید");
            }
        }
    }
}
