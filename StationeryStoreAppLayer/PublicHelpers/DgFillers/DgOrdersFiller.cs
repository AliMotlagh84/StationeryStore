using StationaryStoreUtility.Convertores.DateConvertors;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DgFillers
{
    public class DgOrdersFiller : IDgOrdersFiller
    {
        IMiladiToOtherDateConvertor ToShamsiConvertor = new MiladiToPersianDateConvertor();
        public void FillDgOrders(DataGridView dg, Func<List<OrdersTable>> dataGeterMethod)
        {
            foreach (var order in dataGeterMethod())
            {
                dg.Rows.Add(order.UserId,order.UserId,order.UserName,order.Amount,ToShamsiConvertor.ConvertAsMiladi(order.Date),"کلیک کنید");
            }
        }
    }
}
