using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.FormOpeners
{
    public interface IOrderInfoFormOpener
    {
        void OpenOrderInfoForm(Form senderForm,OrdersTable order);
    }
}
