using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.DTOs.DraftOrderDTO
{
    public class DraftOrderDTO
    {
        public int DraftOrderId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public int RequestedCount { get; set; }
        public long Amount { get; set; }
        public long TotalAmount { get; set; }


    }
}
