using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters
{
    public interface IDraftOrderTotalAmountsSumByUserIdGeter
    {
        long GetDraftOrderTotalAmountsSumByUserId(int userId);
    }
}
