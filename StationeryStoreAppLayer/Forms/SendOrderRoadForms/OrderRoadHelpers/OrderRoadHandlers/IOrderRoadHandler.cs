using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.OrderRoadHelpers.OrderRoadHandlers
{
    public interface IOrderRoadHandler
    {
        void HandleOrderRoad(Form thisForm,DialogResult nextFormDialogResult);
    }
}
