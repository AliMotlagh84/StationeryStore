using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.PublicHelpers.DgFillers
{
    public class DgFiller :IDgFiller
    {
        public void FillDg<T>(DataGridView dg, List<T> data)
        {
            dg.AutoGenerateColumns = false;
            dg.DataSource = data;
        }
    }
}
