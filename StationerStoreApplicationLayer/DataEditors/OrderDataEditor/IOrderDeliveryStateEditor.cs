using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.DataEditors.OrderDataEditor
{
    public interface IOrderDeliveryStateEditor
    {
        void EditDeliveryState(OrdersTable order);
    }
}
