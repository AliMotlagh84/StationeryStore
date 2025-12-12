using StationerStoreApplicationLayer.DataDeleter.OrdersDataDeleters;
using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.DataEditors.OrderDataEditor
{
    public class OrderDataEditor : IOrderDataEditor
    {
        public void EditOrderData(OrdersTable order)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.OrderRepository.Update(order);
                db.Save();
            }
        }
    }
}
