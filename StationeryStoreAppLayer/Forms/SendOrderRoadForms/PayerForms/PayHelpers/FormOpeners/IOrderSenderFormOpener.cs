using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.FormOpeners
{
    public interface IOrderSenderFormOpener
    {
        void OpenPayerFormSender(Form senderForm,UserTable userInfo,long orderTotalAmount);
    }
}
