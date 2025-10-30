using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DgFillers
{
    public interface IDgOrdersFiller
    {
        void FillDgOrders(DataGridView dg, Func<List<OrdersTable>> dataGeterMethod);

    }
}
