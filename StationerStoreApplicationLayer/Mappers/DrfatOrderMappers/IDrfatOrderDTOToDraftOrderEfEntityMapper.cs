using StationerStoreApplicationLayer.DTOs.DraftOrderDTO;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Mappers.DrfatOrderMappers
{
    public interface IDraftOrderDTOToDraftOrderEfEntityMapper
    {
        DraftOrdersTable MapToDraftOrderEfEntity(DraftOrderDTO draftOrderDTO);
    }
}
