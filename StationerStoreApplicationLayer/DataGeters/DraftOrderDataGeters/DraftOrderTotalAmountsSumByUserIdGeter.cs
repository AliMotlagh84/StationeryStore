using StationeryStoreInfrastructureLayer.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters
{
    public class DraftOrderTotalAmountsSumByUserIdGeter : IDraftOrderTotalAmountsSumByUserIdGeter
    {
        public long GetDraftOrderTotalAmountsSumByUserId(int userId)
        {
            using (EfUnitOfWork db = new EfUnitOfWork())
            {
                return db.DraftOrderRepository.GetTotalAmountsSumByUserId(userId);
            }
        }
    }
}
