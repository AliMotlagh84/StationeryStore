using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataGeters.DraftOrderDataGeters
{
    public class DraftOrderDataGeter : IDraftOrderDataGeter
    {
        public List<DraftOrdersTable> GetDraftOrderData()
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                return db.DraftOrderRepository.GetAll();
            }
        }
    }
}
