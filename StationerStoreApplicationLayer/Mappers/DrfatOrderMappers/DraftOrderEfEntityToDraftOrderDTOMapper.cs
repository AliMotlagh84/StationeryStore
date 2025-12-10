using StationerStoreApplicationLayer.DTOs.DraftOrderDTO;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Mappers.DrfatOrderMapers
{
    public class DraftOrderEfEntityToDraftOrderDTOMapper : IDraftOrderEfEntityToDraftOrderDTOMapper
    {
        public DraftOrderDTO MappToDraftOrderDto(DraftOrdersTable draftOrderEfEntity)
        {
            var draftOrderDTO = new DraftOrderDTO()
            {
                DraftOrderId = draftOrderEfEntity.DraftOrderId,
                UserId = draftOrderEfEntity.UserId,
                UserName = draftOrderEfEntity.UserName,
                ProductId = draftOrderEfEntity.ProductId,
                ProductName = draftOrderEfEntity.ProductName,
                BrandId = draftOrderEfEntity.BrandId,
                BrandName = draftOrderEfEntity.BrandName,
                RequestedCount = draftOrderEfEntity.RequestedCount,
                Amount = draftOrderEfEntity.Amount,
                TotalAmount = draftOrderEfEntity.TotalAmount

            };

            return draftOrderDTO;
        }
    }
}
