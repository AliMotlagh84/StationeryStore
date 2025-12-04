using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataGeters.OrdersGeters
{
    public interface IOrdersDataGeter
    {
        List<OrdersTable> GetOrdersData();
    }
}
