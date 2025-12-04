using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers.AmountSearchers;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.SendOrderRoadForms.OrderSenderForms
{
    public interface IOrderSenderForm
    {
        UserTable UserInfo { get; set; }
        long OrderTotalAmount { get; set; }
    }
}
