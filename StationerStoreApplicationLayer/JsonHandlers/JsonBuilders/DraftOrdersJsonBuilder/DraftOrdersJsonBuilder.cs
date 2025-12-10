using StationerStoreApplicationLayer.DTOs.DraftOrderDTO;
using StationerStoreApplicationLayer.Mappers.DrfatOrderMapers;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.JsonHandlers.JsonBuilders.DraftOrdersJsonBuilder
{
    public class DraftOrdersJsonBuilder : IDraftOrdersJsonBuilder
    {
        private IDraftOrderEfEntityToDraftOrderDTOMapper _draftOrderEfEntityToDraftOrderDTOMapper;

        public DraftOrdersJsonBuilder(IDraftOrderEfEntityToDraftOrderDTOMapper draftOrderEfEntityToDraftOrderDTOMapper)
        {
            _draftOrderEfEntityToDraftOrderDTOMapper = draftOrderEfEntityToDraftOrderDTOMapper;
        }

        public string GetDraftOrdersJson(List<DraftOrdersTable> draftOrders)
        {
            List<DraftOrderDTO> draftOrderDTOs = new List<DraftOrderDTO>();
            foreach (var draftorder in draftOrders)
            {
                var draftOrderDTO = _draftOrderEfEntityToDraftOrderDTOMapper.MappToDraftOrderDto(draftorder);
                draftOrderDTOs.Add(draftOrderDTO);
            }

            return JsonSerializer.Serialize(draftOrderDTOs);
        }
    }
}
