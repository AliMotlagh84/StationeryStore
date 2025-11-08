using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataDeleter.DraftOrderDataDeleters
{
    public class DraftOrderDataDeleter : IDraftOrderDataDeleter
    {
        public void DeleteDraftOrderData(int darftOrderId)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.BrandRepository.Delete(darftOrderId);
                db.Save();
            }
        }

        public void DeleteDraftOrderData(DraftOrdersTable draftOrder)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.BrandRepository.Delete(draftOrder);
                db.Save();
            }
        }
    }
}
