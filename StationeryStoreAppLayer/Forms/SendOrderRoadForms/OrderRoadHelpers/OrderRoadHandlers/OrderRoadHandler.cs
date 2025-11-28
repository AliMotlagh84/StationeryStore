using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.OrderRoadHelpers.OrderRoadHandlers
{
    public class OrderRoadHandler : IOrderRoadHandler
    {
        public void HandleOrderRoad(Form thisForm, DialogResult nextFormDialogResult)
        {
            if (nextFormDialogResult != DialogResult.OK)
            {
                thisForm.Show();
            }
            else
            {
                thisForm.DialogResult = DialogResult.OK;            
            }
        }
    }
}
