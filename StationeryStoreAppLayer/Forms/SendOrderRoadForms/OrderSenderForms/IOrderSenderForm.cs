using StationeryStoreAppLayer.PublicHelpers.Searchers.DraftOrderSearchers.AmountSearchers;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.OrderSenderForms
{
    public interface IOrderSenderForm
    {
        UserTable UserInfo { get; set; }
        long OrderTotalAmount { get; set; }
    }
}
