using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataAdders.DraftOrderSenders
{
    public class DraftOrderDataAdder : IDraftOrderDataAdder
    {
        public void AddDraftOrderData(DraftOrdersTable draftOrder)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.DraftOrderRepository.Add(draftOrder);
                db.Save();
            }
        }
    }
}
