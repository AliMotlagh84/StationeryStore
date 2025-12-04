using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters
{
    public class DraftOrderDataGeterById : IDraftOrderDataGeterById
    {
        public DraftOrdersTable GetDraftOrderDataBtId(object draftOrderId)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
               return db.DraftOrderRepository.GetById(draftOrderId);
            }
        }
    }
}
