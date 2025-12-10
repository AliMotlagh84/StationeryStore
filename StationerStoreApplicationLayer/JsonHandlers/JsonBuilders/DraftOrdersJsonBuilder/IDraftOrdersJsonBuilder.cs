using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.JsonHandlers.JsonBuilders.DraftOrdersJsonBuilder
{
    public interface IDraftOrdersJsonBuilder
    {
        string GetDraftOrdersJson(List<DraftOrdersTable> draftOrders);
    }
}
