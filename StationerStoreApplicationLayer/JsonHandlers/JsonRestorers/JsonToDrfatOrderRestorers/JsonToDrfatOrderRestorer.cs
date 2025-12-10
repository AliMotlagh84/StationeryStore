using StationerStoreApplicationLayer.DTOs.DraftOrderDTO;
using StationerStoreApplicationLayer.Mappers.DrfatOrderMappers;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.JsonHandlers.JsonRestorers.JsonToDrfatOrderRestorers
{
    public class JsonToDrfatOrderRestorer : IJsonToDrfatOrderRestorer
    {
        private IDraftOrderDTOToDraftOrderEfEntityMapper _draftOrderDTOToDraftOrderEfEntityMapper;

        public JsonToDrfatOrderRestorer(IDraftOrderDTOToDraftOrderEfEntityMapper draftOrderDTOToDraftOrderEfEntityMapper)
        {
            _draftOrderDTOToDraftOrderEfEntityMapper = draftOrderDTOToDraftOrderEfEntityMapper;
        }

        public List<DraftOrdersTable> RestorJsonToDraftOrder(string JsonString)
        {
            var drfatOrderDTOs = JsonSerializer.Deserialize<List<DraftOrderDTO>>(JsonString);
            List<DraftOrdersTable> draftOrders = new List<DraftOrdersTable>();
            if (drfatOrderDTOs == null)
            {
                return draftOrders;
            }
            foreach (var drfatOrderDTO in drfatOrderDTOs)
            {
                var draftOrder = _draftOrderDTOToDraftOrderEfEntityMapper.MapToDraftOrderEfEntity(drfatOrderDTO);
                draftOrders.Add(draftOrder);
            }
            return draftOrders;

        }




    }
}
