using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataDeleter.DraftOrderDataDeleters
{
    public class DraftOrderDataDeleter : IDraftOrderDataDeleter
    {
        public void DeleteDraftOrderData(int darftOrderId)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.DraftOrderRepository.Delete(darftOrderId);
                db.Save();
            }
        }

        public void DeleteDraftOrderData(DraftOrdersTable draftOrder)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.DraftOrderRepository.Delete(draftOrder);
                db.Save();
            }
        }
    }
}
