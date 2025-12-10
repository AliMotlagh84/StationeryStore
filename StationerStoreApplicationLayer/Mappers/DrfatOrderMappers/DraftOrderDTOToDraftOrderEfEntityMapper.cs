using StationerStoreApplicationLayer.DTOs.DraftOrderDTO;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Mappers.DrfatOrderMappers
{
    public class DraftOrderDTOToDraftOrderEfEntityMapper : IDraftOrderDTOToDraftOrderEfEntityMapper
    {
        public DraftOrdersTable MapToDraftOrderEfEntity(DraftOrderDTO draftOrderDTO)
        {
            var draftOrder = new DraftOrdersTable()
            {
                DraftOrderId = draftOrderDTO.DraftOrderId,
                UserId = draftOrderDTO.UserId,
                UserName = draftOrderDTO.UserName,
                ProductId = draftOrderDTO.ProductId,
                ProductName = draftOrderDTO.ProductName,
                BrandId = draftOrderDTO.BrandId,
                BrandName = draftOrderDTO.BrandName,
                RequestedCount = draftOrderDTO.RequestedCount,
                Amount = draftOrderDTO.Amount,
                TotalAmount = draftOrderDTO.TotalAmount,
            };

            return draftOrder;
        }
    }
}
