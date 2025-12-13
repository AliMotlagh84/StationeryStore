using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.DataEditors.OrderDataEditor
{
    public class OrderDeliveryStateEditor : IOrderDeliveryStateEditor
    {
        public void EditDeliveryState(OrdersTable order)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                order.IsDelivered = !(order.IsDelivered);
                db.OrderRepository.Update(order);
                db.Save();
            }

        }
    }
}
