using StationerStoreApplicationLayer.DTOs.DraftOrderDTO;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.JsonHandlers.JsonRestorers.JsonToDrfatOrderRestorers
{
    public interface IJsonToDrfatOrderRestorer
    {
        public List<DraftOrdersTable> RestorJsonToDraftOrder(string JsonString);
    }
}
