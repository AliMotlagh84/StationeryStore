using StationeryStoreDataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DataEditors.DraftOrderDataEditors
{
    public class DraftOrderDataEditor : IDraftOrderDataEditor
    {
        public void EditDraftOrderData(DraftOrdersTable draftOrder)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                db.DraftOrderRepository.Update(draftOrder);
                db.Save();
            }
        }
    }
}
