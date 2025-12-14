using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.DgOrdersFillingHandlers
{
    public interface IDgOrdersFillingHandler
    {

        public void HandleDgOrdersFilling(DataGridView dataGridView, UserTable userInfo);

    }
}
