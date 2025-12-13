using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.OrderCancelers
{
    public interface IOrderCanceler
    {
        void CancelOrder(int orderId);
    }
}
