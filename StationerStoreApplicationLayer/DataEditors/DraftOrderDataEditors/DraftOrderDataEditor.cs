using StationeryStoreInfrastructureLayer.Models;
using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataEditors.DraftOrderDataEditors
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
