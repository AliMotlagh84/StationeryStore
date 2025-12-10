using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.DataBuilders.OrderDataBuilders
{
    public interface IOrderDataBuilder
    {
        OrdersTable BuildOrderData(int userId,string userName,DateTime orderSendDate,long amount,string orderInfoStringJson,bool IsDeliverd,int? OrderId = null);
    }
}
