using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DgFillers
{
    public interface IDgOrdersFiller
    {
        void FillDgOrders(DataGridView dg, Func<List<OrdersTable>> dataGeterMethod);

    }
}
