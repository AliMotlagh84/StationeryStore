using StationerStoreApplicationLayer.DTOs.DraftOrderDTO;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Mappers.DrfatOrderMapers
{
    public interface IDraftOrderEfEntityToDraftOrderDTOMapper
    {
        DraftOrderDTO MappToDraftOrderDto(DraftOrdersTable draftOrderEfEntity);

    }
}
